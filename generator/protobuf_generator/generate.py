import os
from pathlib import Path
import sys
from proto_schema_parser import ast, Parser
from typing import List

ROOT = Path(__file__).parent
INPUT_DIR = ROOT.parent.parent / "protobufs" / "cs2"
OUT_INTERFACES = ROOT.parent.parent / "managed" / "src" / "SwiftlyS2.Generated" / "Protobufs" / "Interfaces"
OUT_CLASSES = ROOT.parent.parent / "managed" / "src" / "SwiftlyS2.Generated" / "Protobufs" / "Classes"
OUT_ENUMS = ROOT.parent.parent / "managed" / "src" / "SwiftlyS2.Generated" / "Protobufs" / "Enums"

os.makedirs(OUT_INTERFACES, exist_ok=True)
os.makedirs(OUT_CLASSES, exist_ok=True)
os.makedirs(OUT_ENUMS, exist_ok=True)

NETMESSAGE_ENUMS = {
  "EBaseUserMessages": ("UM_", "CUserMessage"),
  "ETEProtobufIds": ("TE_", "CMsgTE"),
  "ECsgoGameEvents": ("GE_", "CMsgTE"),
  "ECstrike15UserMessages": ("CS_UM_", "CCSUsrMsg_"),
  "EBaseGameEvents": ("GE_", "CMsg"),
  "CLC_Messages": ("clc_", "CCLCMsg_"),
  "SVC_Messages": ("svc_", "CSVCMsg_"),
  "NET_Messages": ("net_", "CNETMsg_"),
}

BASE_TYPES = {
  "bool": ("Bool", "bool"),
  "int32": ("Int32", "int"),
  "sint32": ("Int32", "int"),
  "fixed32": ("UInt32", "uint"),
  "int64": ("Int64", "long"),
  "fixed64": ("UInt64", "ulong"),
  "sint64": ("Int64", "long"),
  "uint32": ("UInt32", "uint"),
  "uint64": ("UInt64", "ulong"),
  "float": ("Float", "float"),
  "double": ("Double", "double"),
  "string": ("String", "string"),
  "bytes": ("Bytes", "byte[]"),
}

MANAGED_NESTED_TYPES = {
  "CMsgVector": "Vector",
  "CMsgQAngle": "QAngle",
  "CMsgVector2D": "Vector2D",
  "CMsgRGBA": "Color",
}

FIELD_TEMPLATE = """
  public $CSTYPE$ $CSNAME$
  { get => Accessor.Get$TYPE$("$NAME$"); set => Accessor.Set$TYPE$("$NAME$", value); }
"""

ENUM_FIELD_TEMPLATE = """
  public $CSTYPE$ $CSNAME$
  { get => ($CSTYPE$)Accessor.GetInt32("$NAME$"); set => Accessor.SetInt32("$NAME$", (int)value); }
"""

NESTED_FIELD_TEMPLATE = """
  public $TYPE$ $CSNAME$
  { get => new $TYPE$Impl(NativeNetMessages.GetNestedMessage(GetHandle(), "$NAME$"), false); }
"""

REPEATED_FIELD_TEMPLATE = """
  public $CSTYPE$ $CSNAME$
  { get => new $CSTYPE_IMPL$(Accessor, "$NAME$"); }
"""

INTERFACE_FIELD_TEMPLATE = """
  public $CSTYPE$ $CSNAME$ { get; set; }
"""

INTERFACE_READONLY_FIELD_TEMPLATE = """
  public $CSTYPE$ $CSNAME$ { get; }
"""

IMPL_CLASS_TEMPLATE = """
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class $NAME$ : $BASE_CLASS$<$INTERFACE$>, $INTERFACE$
{
  public $NAME$(nint handle, bool isManuallyAllocated): base(handle)
  {
  }

$FIELDS$
}
"""

NETMESSAGE_IMPL_CLASS_TEMPLATE = """
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class $NAME$ : $BASE_CLASS$<$INTERFACE$>, $INTERFACE$
{
  public $NAME$(nint handle, bool isManuallyAllocated): base(handle, isManuallyAllocated)
  {
  }

$FIELDS$
}
"""

NETMESSAGE_INTERFACE_TEMPLATE = """
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface $NAME$ : ITypedProtobuf<$NAME$>, INetMessage<$NAME$>, IDisposable
{
  static int INetMessage<$NAME$>.MessageId => $MESSAGE_ID$;
  
  static string INetMessage<$NAME$>.MessageName => "$MESSAGE_NAME$";

  static $NAME$ ITypedProtobuf<$NAME$>.Wrap(nint handle, bool isManuallyAllocated) => new $NAME$Impl(handle, isManuallyAllocated);

$FIELDS$
}
"""

NONNETMESSAGE_INTERFACE_TEMPLATE = """
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface $NAME$ : ITypedProtobuf<$NAME$>
{
  static $NAME$ ITypedProtobuf<$NAME$>.Wrap(nint handle, bool isManuallyAllocated) => new $NAME$Impl(handle, isManuallyAllocated);

$FIELDS$
}
"""

ENUM_TEMPLATE = """
namespace SwiftlyS2.Shared.ProtobufDefinitions;

public enum $NAME$
{
$FIELDS$
}
"""

all_enum_names = []

def format_template(template: str, params: dict):
  for key, value in params.items():
    template = template.replace(key, value)
  return template

def to_camel_case(name: str):
  return "".join(word.capitalize() for word in name.split("_"))

def get_field_template(field: ast.Field):

  global all_enum_names

  field.type = field.type.replace(".", "_")
  if field.type.startswith("_"):
    field.type = "." + field.type[1:]

  params = {
    "$CSNAME$": to_camel_case(field.name),
    "$NAME$": field.name,
  }

  if field.type.removeprefix(".") in all_enum_names:
    params["$CSTYPE$"] = field.type.removeprefix(".")
    if field.cardinality == ast.FieldCardinality.REPEATED:
      print("WTF")
      print(field)
      exit(0)

    return format_template(ENUM_FIELD_TEMPLATE, params), format_template(INTERFACE_FIELD_TEMPLATE, params)

  if field.type in BASE_TYPES:
    
    params["$TYPE$"] = BASE_TYPES[field.type][0]
    params["$CSTYPE$"] = BASE_TYPES[field.type][1]
    if field.cardinality == ast.FieldCardinality.REPEATED:
      params["$CSTYPE_IMPL$"] = "ProtobufRepeatedFieldValueType<" + params["$CSTYPE$"] + ">"
      params["$CSTYPE$"] = "I" + params["$CSTYPE_IMPL$"]
      return format_template(REPEATED_FIELD_TEMPLATE, params), format_template(INTERFACE_READONLY_FIELD_TEMPLATE, params)

    return format_template(FIELD_TEMPLATE, params), format_template(INTERFACE_FIELD_TEMPLATE, params)

  if field.type.removeprefix(".") in MANAGED_NESTED_TYPES:
    type = field.type.removeprefix(".")
    params["$TYPE$"] = MANAGED_NESTED_TYPES[type]
    params["$CSTYPE$"] = MANAGED_NESTED_TYPES[type]

    if field.cardinality == ast.FieldCardinality.REPEATED:
      params["$CSTYPE_IMPL$"] = "ProtobufRepeatedFieldValueType<" + params["$CSTYPE$"] + ">"
      params["$CSTYPE$"] = "I" + params["$CSTYPE_IMPL$"]
      return format_template(REPEATED_FIELD_TEMPLATE, params), format_template(INTERFACE_READONLY_FIELD_TEMPLATE, params)

    return format_template(FIELD_TEMPLATE, params), format_template(INTERFACE_FIELD_TEMPLATE, params)

  params["$TYPE$"] = field.type.removeprefix(".")
  params["$CSTYPE$"] = field.type.removeprefix(".")

  if field.cardinality == ast.FieldCardinality.REPEATED:
    params["$CSTYPE_IMPL$"] = "ProtobufRepeatedFieldSubMessageType<" + params["$CSTYPE$"] + ">"
    params["$CSTYPE$"] = "I" + params["$CSTYPE_IMPL$"]
    return format_template(REPEATED_FIELD_TEMPLATE, params), format_template(INTERFACE_READONLY_FIELD_TEMPLATE, params)
  
  return format_template(NESTED_FIELD_TEMPLATE, params), format_template(INTERFACE_READONLY_FIELD_TEMPLATE, params)

def write_netmessage(proto_message: ast.Message, net_message_id: int = -1, prefix=""):
  fields = []
  interface_fields = []

  for field in proto_message.elements:
    
    if isinstance(field, ast.Field):
      impl_field_template, interface_field_template = get_field_template(field)
      fields.append(impl_field_template)
      interface_fields.append(interface_field_template)

    elif isinstance(field, ast.Message):
      write_netmessage(field, -1, prefix + proto_message.name + "_")

  params = {
    "$NAME$": prefix + proto_message.name + "Impl",
    "$BASE_CLASS$": "NetMessage" if net_message_id != -1 else "TypedProtobuf",
    "$INTERFACE$": prefix + proto_message.name,
    "$FIELDS$": "\n".join(fields),
  }
  with open(OUT_CLASSES / (prefix+proto_message.name+"Impl.cs"), "w") as f:
    if net_message_id != -1:
      f.write(format_template(NETMESSAGE_IMPL_CLASS_TEMPLATE, params))
    else:
      f.write(format_template(IMPL_CLASS_TEMPLATE, params))

  interface_params = {
    "$NAME$": prefix + proto_message.name,
    "$MESSAGE_ID$": str(net_message_id),
    "$MESSAGE_NAME$": prefix + proto_message.name,
    "$FIELDS$": "\n".join(interface_fields),
  }
  if net_message_id != -1:
    with open(OUT_INTERFACES / (prefix+proto_message.name+".cs"), "w") as f:
      f.write(format_template(NETMESSAGE_INTERFACE_TEMPLATE, interface_params))
  else:
    with open(OUT_INTERFACES / (prefix+proto_message.name+".cs"), "w") as f:
      f.write(format_template(NONNETMESSAGE_INTERFACE_TEMPLATE, interface_params))

def write_enum(enum: ast.Enum, prefix=""):
  enum_params = {
    "$NAME$": prefix + enum.name,
    "$FIELDS$": "\n".join([f"  {field.name} = {field.number}," if isinstance(field, ast.EnumValue) else "" for field in enum.elements]),
  }
  with open(OUT_ENUMS / (prefix + enum.name+".cs"), "w") as f:
    f.write(format_template(ENUM_TEMPLATE, enum_params))
  
  

def process_enums(root, prefix=""):
  if isinstance(root, ast.File):
    for element in root.file_elements:
        process_enums(element)
  elif isinstance(root, ast.Message):
    for element in root.elements:
        process_enums(element, prefix + root.name + "_")
  elif isinstance(root, ast.Enum):
    all_enum_names.append(prefix + root.name)
    write_enum(root, prefix)

def read_protos():
  global all_enum_names

  parser = Parser()
  
  for file in os.listdir(INPUT_DIR):
    with open(os.path.join(INPUT_DIR, file), "r") as f:
      result = parser.parse(f.read())
      process_enums(result)

  all_enum_names = [enum.replace(".", "_") for enum in all_enum_names]

  for file in os.listdir(INPUT_DIR):
    if True:
      with open(os.path.join(INPUT_DIR, file), "r") as f:
        result = parser.parse(f.read())

        messages: List[ast.Message] = []
        handled_messages = []
        enums: List[ast.Enum] = []
        for element in result.file_elements:
          if isinstance(element, ast.Message):
            messages.append(element)
          if isinstance(element, ast.Enum):
            enums.append(element)

        for enum in enums:
          if enum.name not in NETMESSAGE_ENUMS:
            continue
          handled_enum_fields = []
          enum_prefix, message_prefix = NETMESSAGE_ENUMS[enum.name]
          # print(enum.elements)
          for enum_field in enum.elements:
            name = enum_field.name.removeprefix(enum_prefix)
            if enum.name == "ETEProtobufIds" or enum.name == "ECsgoGameEvents":
              name = name.removesuffix("Id")
            for message in messages:
              if message_prefix in message.name and name in message.name:
                print(f"{message.name} = {enum_field.number};")
                handled_enum_fields.append(enum_field.name)
                handled_messages.append(message)
                write_netmessage(message, enum_field.number)
          
          for enum_field in enum.elements:
            if enum_field.name not in handled_enum_fields:
              print(f"WARNING: MISSING {enum.name}.{enum_field.name}")
        
        for message in messages:
          if message in handled_messages:
            continue

          write_netmessage(message, -1)

read_protos()