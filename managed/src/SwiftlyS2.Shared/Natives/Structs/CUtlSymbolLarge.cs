using System.Runtime.InteropServices;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Shared.Natives;

[StructLayout(LayoutKind.Sequential, Size = 8)]
public struct CUtlSymbolLarge {

  private nint _pString;

  public string Value {
    get {
      if (!_pString.IsValidPtr()) return string.Empty;
      return Marshal.PtrToStringUTF8(_pString)!;
    }
    set {
      // TODO: Implement with AllocPooledString
    }
  }
}
