using System.Runtime.InteropServices;
using SwiftlyS2.Core.Natives;

namespace SwiftlyS2.Shared.Natives;

/// <summary>
/// Pointer to a native handle.
/// </summary>
[StructLayout(LayoutKind.Sequential, Size = 8)]
public struct PointerTo<T> where T : INativeHandle {
  private nint _pointer;

  public readonly T Value => NativeHandleConversion.As<T>(_pointer);
}