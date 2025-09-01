using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives.NativeObjects;

internal abstract class NativeHandle : INativeHandle {
  protected nint _Handle { get; set; }

  public bool IsValid { get => _Handle != nint.Zero; }

  public NativeHandle(nint handle) {
    _Handle = handle;
  }

  public nint GetHandle() {
    if (!IsValid) throw new InvalidOperationException("Trying to get a invalid handle.");
    return _Handle;
  } 
}