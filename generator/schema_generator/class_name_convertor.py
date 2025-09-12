def get_interface_name(class_name: str) -> str:

  # if class_name[0] != 'C':
  #   return 'I' + class_name
  
  # if class_name[1].isupper():
  #   return 'I' + class_name.removeprefix("C")
  
  names = ["SchemaClass", "SchemaField", "SchemaFixedArray", "SchemaFixedString"]
  if class_name in names:
    return "I" + class_name
  
  return class_name.replace(":", "_")

if __name__ == "__main__":
  test_cases = [
    "CBaseEntity",
    "ParticleAttributeIndex_t"
  ]

  for test_case in test_cases:
    print(f"{test_case} -> {get_interface_name(test_case)}")


def get_impl_name(class_name: str) -> str:
  
  names = ["SchemaClass", "SchemaField", "SchemaFixedArray", "SchemaFixedString"]
  if class_name in names:
    return class_name
  return class_name.replace(":", "_") + "Impl"

if __name__ == "__main__":
  test_cases = [
    "CBaseEntity",
    "ParticleAttributeIndex_t"
  ]

  for test_case in test_cases:
    print(f"{test_case} -> {get_interface_name(test_case)}")

