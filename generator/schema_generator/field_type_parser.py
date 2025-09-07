from class_name_convertor import get_interface_name


unmanaged_type_maps = {
  "int8": "byte",
  "int16": "short",
  "int32": "int",
  "int64": "long",
  "uint8": "byte",
  "uint16": "ushort",
  "uint32": "uint",
  "uint64": "ulong",
  "float32": "float",
  "float64": "double", # fuck you valve
  "double": "double",
  "bool": "bool",
  "char": "char",
  "Vector": "Vector",
  "QAngle": "QAngle",
  "CUtlVector": "CUtlVector",
  "Quaternion": "Quaternion",
  "Vector2D": "Vector2D",
  "Vector4D": "Vector4D",
  "CStrongHandle": "CStrongHandle",
  "CUtlSymbolLarge": "CUtlSymbolLarge",
  "CUtlString": "CUtlString",
  "Color": "Color",
  "CHandle": "CHandle",
  "CBufferString": "CBufferString",
  "CGlobalSymbol": "CGlobalSymbol",
  "CTransform": "CTransform",
  "CUtlLeanVector": "CUtlLeanVector",
  "CNetworkedQuantizedFloat": "CNetworkedQuantizedFloat",
  "CUtlBinaryBlock": "CUtlBinaryBlock",
  "fltx4": "fltx4",
  "FourVectors": "FourVectors",
  "CEntityIndex": "CEntityIndex",
  "matrix3x4_t": "matrix3x4_t",
  "matrix3x4a_t": "matrix3x4a_t",
  "CUtlSymbol": "CUtlSymbol",
  "CSplitScreenSlot": "CSplitScreenSlot",
  "CPlayerSlot": "CPlayerSlot",
  "RadianEuler": "RadianEuler",
  "WorldGroupId_t": "WorldGroupId_t",
  "CNetworkUtlVectorBase": "CUtlVector",
  "CTypedBitVec": "CBitVec",
  "DegreeEuler": "DegreeEuler",
  "CEntityHandle": "CEntityHandle",
  "CWeakHandle": "CWeakHandle"
}

blacklisted_types = [
  "CSmartPtr",
  "CUtlHashtable",
  "CUtlOrderedMap",
  "CPulseValueFullType",
  "PulseSymbol_t",
  "CColorGradient",
  "CPiecewiseCurve",
  "CAnimGraph2ParamOptionalRef",
  "HSCRIPT",
  "Range_t",
  "CAnimGraphParamRef",
  "bitfield",
  "KeyValues3",
  "KeyValues",
  "CResourceName",
  "CParticleNamedValueRef",
  "CKV3MemberNameSet",
  "CAnimGraphTagRef",
  "CResourceNameTyped",
  "CResourceArray",
  "CAnimGraphParamOptionalRef",
  "CAnimVariant",
  "RotationVector",
  "CAnimScriptParam",
  "CKV3MemberNameWithStorage",
  "CModelAnimNameWithDeltas",
  "CAnimValue",
  "CEntityOutputTemplate",
  "CVariantBase",
  "SphereBase_t",
  "CAttachmentNameSymbolWithStorage",
]


def convert_field_type(type, kind, all_class_names, all_enum_names, interface = False):

  prefix = "I" if interface else ""

  for blacklisted_type in blacklisted_types:
    if type.startswith(blacklisted_type):
      return (f"{prefix}SchemaUntypedField", False)

  if kind == "ptr" and type == "char": # char*
    return (f"CString", True)


  for key, value in unmanaged_type_maps.items():
    if type.startswith(key):
      
      if kind == "fixed_array":
        if type == "char":
          return (f"{prefix}SchemaFixedString", False)
        return (f"{prefix}SchemaFixedArray<{type}>", False)
      return (f"{type.replace(key, value)}", True)

  if type in all_enum_names:
    return (type, True)

  if type in all_class_names:
    complex_type = type if not interface else get_interface_name(type)
    return (complex_type, False)
  
  print(f"Unknown type: {type}")
  return (type, False)