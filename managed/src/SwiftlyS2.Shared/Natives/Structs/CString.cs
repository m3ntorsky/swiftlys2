using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace SwiftlyS2.Shared.Natives;

/// <summary>
/// Wrapper class for native char*.
/// </summary>
[StructLayout(LayoutKind.Explicit, Size = 8)]
public struct CString {

  private static List<nint> _allocated = new List<nint>();

  [FieldOffset(0)]
  private nint _ptr;
  
  public string Value {
    get {
      if (_ptr == nint.Zero) {
        return string.Empty;
      }
      return Marshal.PtrToStringUTF8(_ptr)!;
    }

    set {
      if (_ptr == nint.Zero) {
        // maybe a warning here
      }
      unsafe {
        if (_allocated.Contains(_ptr)) {
          NativeMemory.Free(_ptr.ToPointer());
          _allocated.Remove(_ptr);
        }
        var bytes = Encoding.UTF8.GetBytes(value);
        _ptr = (nint)NativeMemory.Alloc((nuint)bytes.Length + 1);
        fixed (byte* p = bytes) {
          NativeMemory.Copy(p, (byte*)_ptr, (nuint)bytes.Length);
        }
        ((byte*)_ptr)[bytes.Length] = 0;
        _allocated.Add(_ptr);
      }
    }
  }
}
