def get_interface_name(class_name: str) -> str:

  if class_name[0] != 'C':
    return 'I' + class_name
  
  if class_name[1].isupper():
    return 'I' + class_name.removeprefix("C")
  
  return 'I' + class_name

if __name__ == "__main__":
  test_cases = [
    "CBaseEntity",
    "ParticleAttributeIndex_t"
  ]

  for test_case in test_cases:
    print(f"{test_case} -> {get_interface_name(test_case)}")

