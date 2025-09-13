using System.Buffers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Shared.Natives;

/// <summary>
/// Wrapper class for native char*.
/// </summary>
[StructLayout(LayoutKind.Explicit, Size = 8)]
public struct CString {

  // private static List<nint> _allocated = new List<nint>();

  [FieldOffset(0)]
  private nint _pString; // char*
  
  public string Value {
    get {
      if (!_pString.IsValidPtr()) {
        return string.Empty;
      }
      return Marshal.PtrToStringUTF8(_pString)!;
    }

    set {
      if (_pString == nint.Zero) {
        // maybe a warning here
      }
      // unsafe {
      //   if (_allocated.Contains(_pString)) {
      //     NativeMemory.Free(_pString.ToPointer());
      //     _allocated.Remove(_pString);
      //   }
      //   var bytes = Encoding.UTF8.GetBytes(value);
      //   _pString = (nint)NativeMemory.Alloc((nuint)bytes.Length + 1);
      //   fixed (byte* p = bytes) {
      //     NativeMemory.Copy(p, (byte*)_pString, (nuint)bytes.Length);
      //   }
      //   ((byte*)_pString)[bytes.Length] = 0;
      //   _allocated.Add(_pString);
      // }
    }
  }
}
