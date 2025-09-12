from class_name_convertor import get_interface_name
import json
import os
from tqdm import tqdm

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
    self.size = class_def["size"]
    self.class_name = self.class_name.replace(":", "_")
    
    self.interface_name = get_interface_name(self.class_name)


    self.class_ref_field_template = open("templates/class_ref_field_template.cs", "r").read()
    self.class_value_field_template = open("templates/class_value_field_template.cs", "r").read()
    self.class_fixed_array_field_template = open("templates/class_fixed_array_field_template.cs", "r").read()

    self.interface_field_template = open("templates/interface_field_template.cs", "r").read()
    self.class_template = open("templates/class_template.cs", "r").read()
    self.interface_template = open("templates/interface_template.cs", "r").read()
    self.class_updator_template = open("templates/class_updator_template.cs", "r").read()

    self.conversion_type_template = open("templates/conversion_type_template.cs", "r").read()

    self.enum_template = open("templates/enum_template.cs", "r").read()

    self.base_class = self.class_def["base_classes"][0] if "base_classes" in self.class_def else "SchemaClass"
  
  def write_conversion(self, conversions):
    params = {
      "INTERFACE_NAME": self.interface_name,
      "CLASS_NAME": self.class_name,
    }
    conversions.append(render_template(self.conversion_type_template, params))

  def write_class(self):
    self.class_file_handle = open(f"output/Classes/{self.class_name}.cs", "w")

    fields = []
    updators = []

    if "fields" in self.class_def:
      for field in self.class_def["fields"]:
        field_info = parse_field(field, self.all_class_names, self.all_enum_names)
        
        field_info["REF_METHOD"] = "Deref" if field_info["KIND"] == "ptr" else "AsRef"

        if field_info["IS_NETWORKED"] == "true":
          updators.append(render_template(self.class_updator_template, field_info))

        elif field_info["KIND"] == "fixed_array":
          fields.append(render_template(self.class_fixed_array_field_template, field_info))
        elif field_info["IS_VALUE_TYPE"]:
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
    self.interface_file_handle = open(f"output/Interfaces/{self.interface_name}.cs", "w")

    fields = []

    # the types whose generic has been erased, we add a comment to tell user whats the real type
    erased_generics = [
      "CUtlVector",
      "CUtlVectorFixedGrowable",
      "CUtlVectorEmbeddedNetworkVar",
      "CNetworkUtlVectorBase",
    ]

    if "fields" in self.class_def:
      for field in self.class_def["fields"]:
        field_info = parse_field(field, self.all_class_names, self.all_enum_names)
      
        field_info["REF"] = "ref " if field_info["IS_VALUE_TYPE"] else ""
        field_info["COMMENT"] = ""

        if field_info["IMPL_TYPE"] in erased_generics and "templated" in field:
          field_info["COMMENT"] = f"\n// {field['templated']}"

        fields.append(render_template(self.interface_field_template, field_info))

    params = {
      "INTERFACE_NAME": self.interface_name,
      "BASE_INTERFACE": get_interface_name(self.base_class),
      "FIELDS": "\n".join(fields)
    }
    self.interface_file_handle.write(render_template(self.interface_template, params))

  def write_enum(self):
    enum_file_handle = open(f"output/Enums/{self.class_name}.cs", "w")
    types = {
      1: "byte",
      2: "ushort",
      4: "uint",
      8: "ulong"
    }

    type = types[self.size]

    fields = []
    for field in self.class_def["fields"]:
      value = str(field["value"]) if field["value"] != -1 else f"{type}.MaxValue"
      fields.append(f" {field["name"]} = {value};")

    params = {
      "ENUM_NAME": self.class_name,
      "BASE_TYPE": type,
      "ENUM_VALUES": "\n".join(fields)
    }
    enum_file_handle.write(render_template(self.enum_template, params))


if not os.path.exists("output"):
  os.makedirs("output/Classes")
  os.makedirs("output/Interfaces")
  os.makedirs("output/Enums")


with open("sdk.json", "r") as f:
  data = json.load(f)

  all_class_names = [class_def["name"] for class_def in data["classes"]]
  all_enum_names = [enum_def["name"] for enum_def in data["enums"]]

  conversions = []
  for class_def in tqdm(data["classes"], desc="Classes"):
    writer = Writer(class_def, all_class_names, all_enum_names)
    writer.write_conversion(conversions)
    writer.write_class()
    writer.write_interface()

  for enum_def in tqdm(data["enums"], desc="Enums"):
    writer = Writer(enum_def, all_class_names, all_enum_names)
    writer.write_enum()

  with open("output/Conversions.cs", "w") as f:
    with open ("templates/conversion_template.cs", "r") as t:
      f.write(render_template(t.read(), {
        "CONVERSIONS": "\n".join(conversions)
      }))