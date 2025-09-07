from class_name_convertor import get_interface_name
import json
import os

from field_parser import parse_field

def render_template(template, params):
  for param, value in params.items():
    template = template.replace(f"${param}$", str(value))
  return template

class Writer():

  def __init__(self, class_def, all_class_names, all_enum_names):
    self.class_def = class_def
    self.all_class_names = all_class_names
    self.all_enum_names = all_enum_names

    self.class_name = class_def["name"]
    self.class_name = self.class_name.replace(":", "_")
    
    self.interface_name = get_interface_name(self.class_name)

    self.class_file_handle = open(f"output/Classes/{self.class_name}.cs", "w")
    self.interface_file_handle = open(f"output/Interfaces/{self.interface_name}.cs", "w")

    self.class_ref_field_template = open("templates/class_ref_field_template.cs", "r").read()
    self.class_value_field_template = open("templates/class_value_field_template.cs", "r").read()

    self.interface_field_template = open("templates/interface_field_template.cs", "r").read()
    self.class_template = open("templates/class_template.cs", "r").read()
    self.interface_template = open("templates/interface_template.cs", "r").read()
    self.class_updator_template = open("templates/class_updator_template.cs", "r").read()

    self.conversion_type_template = open("templates/conversion_type_template.cs", "r").read()

    self.base_class = self.class_def["base_classes"][0] if "base_classes" in self.class_def else "SchemaClass"
  
  def write_conversion(self, conversions):
    params = {
      "INTERFACE_NAME": self.interface_name,
      "CLASS_NAME": self.class_name,
    }
    conversions.append(render_template(self.conversion_type_template, params))

  def write_class(self):

    fields = []
    updators = []

    if "fields" in self.class_def:
      for field in self.class_def["fields"]:
        field_info = parse_field(field, self.all_class_names, self.all_enum_names)
        
        field_info["REF_METHOD"] = "Deref" if field_info["KIND"] == "ptr" else "AsRef"

        if field_info["IS_NETWORKED"] == "true":
          updators.append(render_template(self.class_updator_template, field_info))

        if field_info["IS_VALUE_TYPE"]:
          fields.append(render_template(self.class_value_field_template, field_info))
        else:
          fields.append(render_template(self.class_ref_field_template, field_info))

    params = {
      "CLASS_NAME": self.class_name,
      "INTERFACE_NAME": self.interface_name,
      "BASE_CLASS": self.base_class,
      "BASE_INTERFACE": get_interface_name(self.base_class),
      "FIELDS": "\n".join(fields),
      "UPDATORS": "\n".join(updators)
    }

    self.class_file_handle.write(render_template(self.class_template, params))

  def write_interface(self):
    params = {
      "INTERFACE_NAME": self.interface_name,
      "BASE_INTERFACE": get_interface_name(self.base_class),
      "FIELDS": ""
    }
    self.interface_file_handle.write(render_template(self.interface_template, params))

if not os.path.exists("output"):
  os.makedirs("output/Classes")
  os.makedirs("output/Interfaces")


with open("sdk.json", "r") as f:
  data = json.load(f)

  all_class_names = [class_def["name"] for class_def in data["classes"]]
  all_enum_names = [enum_def["name"] for enum_def in data["enums"]]

  conversions = []
  for class_def in data["classes"]:
    try:
      writer = Writer(class_def, all_class_names, all_enum_names)
      writer.write_conversion(conversions)
      writer.write_class()
      writer.write_interface()
    except Exception as e:
      print(f"Error: {e}")

  with open("output/Conversions.cs", "w") as f:
    with open ("templates/conversion_template.cs", "r") as t:
      f.write(render_template(t.read(), {
        "CONVERSIONS": "\n".join(conversions)
      }))