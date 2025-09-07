
type_prefixes = [
    "psz",
    "fl",
    "a",
    "n",
    "i",
    "isz",
    "vec",
    "us",
    "u",
    "ub",
    "un",
    "sz",
    "b",
    "f",
    "clr",
    "h",
    "ang",
    "af",
    "ch",
    "q",
    "p",
    "v",
    "arr",
    "bv",
    "e",
    "s",
]

def convert_field_name(field_name: str) -> str:
  field_name = field_name.removeprefix("m_")

  for prefix in type_prefixes:
    if field_name.startswith(prefix):
      temp_removed = field_name.removeprefix(prefix)
      if len(temp_removed) > 0 and temp_removed[0].isupper():
        return temp_removed
  
  field_name = field_name[0].upper() + field_name[1:]
  return field_name

if __name__ == "__main__":
  test_cases = [
    "m_flRadius",
    "nType",
    "m_aAngOffset",
    "m_action"
  ]

  for test_case in test_cases:
    print(f"{test_case} -> {convert_field_name(test_case)}")

