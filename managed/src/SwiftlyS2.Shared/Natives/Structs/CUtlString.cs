using System.Runtime.InteropServices;
using SwiftlyS2.Core.Natives;

namespace SwiftlyS2.Shared.Natives;

[StructLayout(LayoutKind.Sequential, Size = 8)]
public struct CUtlString {

  private nint _ptr;

  public string Value {

    get => Marshal.PtrToStringUTF8(_ptr)!;
    set => _ptr = StringPool.Allocate(value);

  }
}