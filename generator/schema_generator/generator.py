from class_name_convertor import get_interface_name, get_impl_name
import json
import os
from tqdm import tqdm
from pathlib import Path

from field_parser import parse_field

OUT_DIR = Path("../../managed/src/SwiftlyS2.Generated/Schemas/")

if not os.path.exists(OUT_DIR):
  os.makedirs(OUT_DIR)
  os.makedirs(OUT_DIR / "Classes")
  os.makedirs(OUT_DIR / "Interfaces")
  os.makedirs(OUT_DIR / "Enums")

# no one need them
blacklisted_classes = [
  "FeSimdTri_t"
]


managed_types = [
  "SchemaClass",
  "SchemaField",
  "SchemaFixedArray",
  "SchemaFixedString"
]

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
    
    self.interface_name = get_impl_name(self.class_name)


    self.class_ref_field_template = open("templates/class_ref_field_template.cs", "r").read()
    self.class_value_field_template = open("templates/class_value_field_template.cs", "r").read()
    self.class_fixed_array_field_template = open("templates/class_fixed_array_field_template.cs", "r").read()
    self.class_ptr_field_template = open("templates/class_ptr_field_template.cs", "r").read()

    self.interface_field_template = open("templates/interface_field_template.cs", "r").read()
    self.class_template = open("templates/class_template.cs", "r").read()
    self.interface_template = open("templates/interface_template.cs", "r").read()
    self.class_updator_template = open("templates/class_updator_template.cs", "r").read()
    self.interface_updator_template = open("templates/interface_updator_template.cs", "r").read()

    self.conversion_type_template = open("templates/conversion_type_template.cs", "r").read()

    self.enum_template = open("templates/enum_template.cs", "r").read()

    self.base_class = self.class_def["base_classes"][0] if "base_classes" in self.class_def else "SchemaClass"
    self.base_class = self.base_class.replace(":", "_")
  
  def write_conversion(self, conversions):
    params = {
      "INTERFACE_NAME": get_interface_name(self.class_name),
      "CLASS_NAME": get_impl_name(self.class_name),
    }
    conversions.append(render_template(self.conversion_type_template, params))

  def write_class(self):
    self.class_file_handle = open(OUT_DIR / "Classes" / f"{get_impl_name(self.class_name)}.cs", "w")

    fields = []
    updators = []

    duplicated_counter = 0
    names = []

    if "fields" in self.class_def:
      for field in self.class_def["fields"]:

        field_info = parse_field(field, self.all_class_names, self.all_enum_names)

        if field_info["NAME"] in names:
          duplicated_counter += 1
          field_info["NAME"] = f"{field_info['NAME']}{duplicated_counter}"
        else:
          names.append(field_info["NAME"])

        field_info["REF_METHOD"] = "Deref" if field_info["KIND"] == "ptr" else "AsRef"

        if field_info["IS_NETWORKED"] == "true":
          updators.append(render_template(self.class_updator_template, field_info))

        if field_info["KIND"] == "fixed_array" and field_info["IMPL_TYPE"] != "SchemaUntypedField":
          fields.append(render_template(self.class_fixed_array_field_template, field_info))
        elif field_info["IS_VALUE_TYPE"]:
          fields.append(render_template(self.class_value_field_template, field_info))
        else:
          if field_info["KIND"] == "ptr" and field_info["IMPL_TYPE"] not in managed_types:
            fields.append(render_template(self.class_ptr_field_template, field_info))
          else:
            fields.append(render_template(self.class_ref_field_template, field_info))

    params = {
      "CLASS_NAME": get_impl_name(self.class_name),
      "INTERFACE_NAME": get_interface_name(self.class_name),
      "BASE_CLASS": get_impl_name(self.base_class),
      "BASE_INTERFACE": get_interface_name(self.base_class),
      "FIELDS": "\n".join(fields),
      "UPDATORS": "\n".join(updators)
    }

    self.class_file_handle.write(render_template(self.class_template, params))

  def write_interface(self):
    self.interface_file_handle = open(OUT_DIR / "Interfaces" / f"{get_interface_name(self.class_name)}.cs", "w")

    fields = []
    updators = []

    # the types whose generic has been erased, we add a comment to tell user whats the real type
    erased_generics = [
      "CUtlVector",
      "CUtlVectorFixedGrowable",
      "CUtlVectorEmbeddedNetworkVar",
      "CNetworkUtlVectorBase",
    ]

    duplicated_counter = 0
    names = []

    if "fields" in self.class_def:
      for field in self.class_def["fields"]:
        field_info = parse_field(field, self.all_class_names, self.all_enum_names)
      
        
        if field_info["NAME"] in names:
          duplicated_counter += 1
          field_info["NAME"] = f"{field_info['NAME']}{duplicated_counter}"
        else:
          names.append(field_info["NAME"])

        field_info["REF"] = "ref " if field_info["IS_VALUE_TYPE"] else ""
        field_info["COMMENT"] = ""

        if field_info["IMPL_TYPE"] in erased_generics or field_info["IMPL_TYPE"] == "SchemaUntypedField":
          if "templated" in field:
            field_info["COMMENT"] = f"\n  // {field['templated']}"
          else:
            field_info["COMMENT"] = f"\n  // {field['type']}"

        if field_info["IS_NETWORKED"] == "true":
          updators.append(render_template(self.interface_updator_template, field_info))

        fields.append(render_template(self.interface_field_template, field_info))

    params = {
      "INTERFACE_NAME": get_interface_name(self.class_name),
      "BASE_INTERFACE": get_interface_name(self.base_class),
      "FIELDS": "\n".join(fields),
      "UPDATORS": "\n".join(updators)
    }
    self.interface_file_handle.write(render_template(self.interface_template, params))

  def write_enum(self):
    enum_file_handle = open(OUT_DIR / "Enums" / f"{self.class_name}.cs", "w")
    types = {
      1: "byte",
      2: "ushort",
      4: "uint",
      8: "ulong"
    }

    type = types[self.size]

    fields = []
    for field in self.class_def["fields"]:
      value = field["value"] if field["value"] != -1 else f"{type}.MaxValue"
      value = value if value != -2 else f"{type}.MaxValue - 1"
      fields.append(f" {field["name"]} = {value},")

    params = {
      "ENUM_NAME": self.class_name,
      "BASE_TYPE": type,
      "ENUM_VALUES": "\n\n".join(fields)
    }
    enum_file_handle.write(render_template(self.enum_template, params))

with open("sdk.json", "r") as f:
  data = json.load(f)

  all_class_names = [class_def["name"] for class_def in data["classes"]]
  all_enum_names = [enum_def["name"] for enum_def in data["enums"]]

  conversions = []
  for class_def in tqdm(data["classes"], desc="Classes"):
    if class_def["name"] in blacklisted_classes:
      continue

    writer = Writer(class_def, all_class_names, all_enum_names)
    writer.write_conversion(conversions)
    writer.write_class()
    writer.write_interface()

  for enum_def in tqdm(data["enums"], desc="Enums"):
    if enum_def["name"] in blacklisted_classes:
      continue

    writer = Writer(enum_def, all_class_names, all_enum_names)
    writer.write_enum()

  with open(OUT_DIR / "Conversions.cs", "w") as f:
    with open ("templates/conversion_template.cs", "r") as t:
      f.write(render_template(t.read(), {
        "CONVERSIONS": "\n".join(conversions)
      }))