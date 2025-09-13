import os
from pathlib import Path

INDENT = "  "

PARAM_TYPE_MAP = {
    "int32": "int",
    "float": "float",
    "double": "double",
    "bool": "bool",
    "byte": "byte",
    "int64": "long",
    "uint32": "uint",
    "uint64": "ulong",
    "ptr": "void*",
    "string": "string",
    "void": "void",
}

DELEGATE_PARAM_TYPE_MAP = {
    **PARAM_TYPE_MAP,
    "string": "byte*",
}

DELEGATE_RETURN_TYPE_MAP = {
    **PARAM_TYPE_MAP,
    "string": "int",
}

RETURN_TYPE_MAP = {
    **PARAM_TYPE_MAP,
    "string": "string",
}

EOL = os.linesep


def split_by_last_dot(value: str):
    idx = value.rfind(".")
    if idx == -1:
        return "", value
    return value[:idx], value[idx + 1 :]


def is_buffer_return(return_type: str) -> bool:
    return return_type == "string"


def make_string_marshal(param_name: str, state: dict):
    pre_lines = [
        f"{param_name}BufferPtr",
        (
            ""
            if state.get("pool")
            else f"{INDENT}{INDENT}var pool = ArrayPool<byte>.Shared;"
        )
        + f"{EOL}"
        f"{INDENT}{INDENT}var {param_name}Length = Encoding.UTF8.GetByteCount({param_name});{EOL}"
        f"{INDENT}{INDENT}var {param_name}Buffer = pool.Rent({param_name}Length + 1);{EOL}"
        f"{INDENT}{INDENT}Encoding.UTF8.GetBytes({param_name}, {param_name}Buffer);{EOL}"
        f"{INDENT}{INDENT}{param_name}Buffer[{param_name}Length] = 0;{EOL}"
        f"{INDENT}{INDENT}fixed (byte* {param_name}BufferPtr = {param_name}Buffer) {{{EOL}",
        f"{INDENT}{INDENT}pool.Return({param_name}Buffer);{EOL}{EOL}",
    ]
    state["pool"] = True
    state["closing_bracket"] = state.get("closing_bracket", 0) + 1
    return pre_lines


def make_string_return_marshal(state: dict):
    pre_lines = [
        "retString",
        (
            ""
            if state.get("pool")
            else f"{INDENT}{INDENT}var pool = ArrayPool<byte>.Shared;"
        )
        + f"{EOL}"
        f"{INDENT}{INDENT}var retBuffer = pool.Rent(ret);{EOL}"
        f"{INDENT}{INDENT}fixed (byte* retBufferPtr = retBuffer) {{{EOL}",
        f"{INDENT}{INDENT}var retString = Encoding.UTF8.GetString(retBufferPtr, ret);{EOL}"
        f"{INDENT}{INDENT}pool.Return(retBuffer);{EOL}{EOL}",
    ]
    state["pool"] = True
    state["closing_bracket"] = state.get("closing_bracket", 0) + 1
    return pre_lines


def emit(chunks: list[str], text: str = ""):
    chunks.append(text + EOL)


def parse_native(lines: list[str]):
    namespace_line, *native_lines = lines
    namespace_content = namespace_line.split(" ")[1].strip()
    namespace_prefix, class_name = split_by_last_dot(namespace_content)
    print(class_name)

    out_path = Path("output") /  f"{class_name}.cs"
    out_path.parent.mkdir(parents=True, exist_ok=True)

    chunks: list[str] = []
    emit(chunks, "using System.Buffers;")
    emit(chunks, "using System.Text;")
    emit(chunks)
    emit(chunks, f"namespace SwiftlyS2.NativeTables.{class_name};")
    emit(chunks)
    emit(chunks, f"public static class NativeTable_{class_name} {{")

    for raw_line in native_lines:
        if raw_line.strip() == "":
            continue
        left, right = raw_line.split("=", 1)
        return_type, function_name = left.split(" ", 1)
        params_and_comment = right.split("//", 1)
        native_params_raw = params_and_comment[0] if params_and_comment else ""
        comment = params_and_comment[1] if len(params_and_comment) > 1 else ""
        trimmed_params = native_params_raw.strip()
        native_params_list = [] if trimmed_params in ("", "void") else [p for p in trimmed_params.split(",")]

        native_param_types = [DELEGATE_PARAM_TYPE_MAP[p.strip().split(" ", 1)[0]] for p in native_params_list]
        param_signatures = []
        for p in native_params_list:
            t, n = p.strip().split(" ", 1)
            param_signatures.append((PARAM_TYPE_MAP[t], n))

        native_param_types_with_buffer = ["byte*", *native_param_types] if is_buffer_return(return_type) else native_param_types
        delegate_generic = ", ".join([*native_param_types_with_buffer, DELEGATE_RETURN_TYPE_MAP[return_type]])
        emit(chunks, f"{INDENT}private unsafe static delegate* unmanaged<{delegate_generic}> _{function_name};")

        if comment and comment.strip() != "":
            emit(chunks, f"{INDENT}/// <summary>")
            emit(chunks, f"{INDENT}/// {comment.strip()}")
            emit(chunks, f"{INDENT}/// </summary>")

        method_signature = ", ".join([f"{t} {n}" for t, n in param_signatures])
        emit(chunks, f"{INDENT}public unsafe static {RETURN_TYPE_MAP[return_type]} {function_name}({method_signature}) {{")

        marshals: list[tuple[str, str]] = []
        renamed_param: dict[str, str] = {}
        state: dict = {"closing_bracket": 0}
        renamed_ret = "ret"
        ret_marshal: tuple[str, str] | None = None

        for t, n in param_signatures:
            if t == "string":
                new_name, pre_code, post_code = make_string_marshal(n, state)
                renamed_param[n] = new_name
                marshals.append((pre_code, post_code))
            else:
                renamed_param[n] = n

        if is_buffer_return(return_type):
            new_name, pre_code, post_code = make_string_return_marshal(state)
            renamed_ret = new_name
            ret_marshal = (pre_code, post_code)

        for pre_code, _ in marshals:
            chunks.append(pre_code)

        if is_buffer_return(return_type):
            param_args = [renamed_param[n] for _, n in param_signatures]
            args_first = ", ".join(["null", *param_args])
            emit(chunks, f"{INDENT}{INDENT}var ret = _{function_name}({args_first});")
            ret_pre_code, _ = ret_marshal  # type: ignore
            chunks.append(ret_pre_code)
            args_second = ", ".join(["retBufferPtr", *param_args])
            emit(chunks, f"{INDENT}{INDENT}ret = _{function_name}({args_second});")
        elif return_type == "void":
            call_args = ", ".join([renamed_param[n] for _, n in param_signatures])
            emit(chunks, f"{INDENT}{INDENT}_{function_name}({call_args});")
        else:
            call_args = ", ".join([renamed_param[n] for _, n in param_signatures])
            emit(chunks, f"{INDENT}{INDENT}var ret = _{function_name}({call_args});")

        if is_buffer_return(return_type) and ret_marshal:
            _, ret_post_code = ret_marshal
            chunks.append(ret_post_code)

        for _, post_code in marshals:
            chunks.append(post_code)

        if return_type != "void":
            emit(chunks, f"{INDENT}{INDENT}return {renamed_ret};")


        for _ in range(state["closing_bracket"] + 1):
            emit(chunks, f"{INDENT}{"}"}")

    emit(chunks, "}")

    with open(out_path, "w", encoding="utf-8", newline="") as f:
        f.write("".join(chunks))


def main():
    definitions_dir = Path("../../natives")
    for entry in os.listdir(definitions_dir):
        file_path = definitions_dir / entry
        if file_path.is_file():
            with open(file_path, "r", encoding="utf-8") as f:
                parse_native(f.readlines())


if __name__ == "__main__":
    main() 