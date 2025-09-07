using System.Runtime.InteropServices;
using System.Text;
using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.Schemas;

internal class SchemaFixedString : SchemaFixedArray<byte>, ISchemaFixedString {

  public SchemaFixedString(nint handle, ulong offset, bool isOptional, bool isNullable, int elementAlignment, int elementCount, int elementSize) : base(handle, offset, isOptional, isNullable, elementAlignment, elementCount, elementSize) {
  }

  public string Value {
    get {
      return Marshal.PtrToStringUTF8(_Handle + FieldOffset)!;
    }
    set {
      unsafe {
        var bytes = Encoding.UTF8.GetBytes(value);
        if (bytes.Length + 1 > ElementCount) {
          throw new ArgumentException("Value is too long for the fixed string");
        }
        fixed (byte* p = bytes) {
          NativeMemory.Copy(p, (byte*)(_Handle + FieldOffset), (nuint)bytes.Length);
        }
      }
    }
  }
}