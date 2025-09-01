using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Core.Natives;

internal abstract class NativeObject : INativeObject {
  protected nint _Ptr { get; set; }

  protected bool _IsManuallyAllocated { get; init; } = false;

  protected bool _Disposed { get; set; } = false;

  public NativeObject(nint ptr) {
    _Ptr = ptr;
    _IsManuallyAllocated = false;
  }

  public nint GetPtr() {
    return _Ptr;
  } 

  ~NativeObject() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    if (_Disposed) return;

    if (disposing) {
      // free managed here
    }

    if (_IsManuallyAllocated) {
      Free();
    };
    _Ptr = nint.Zero;
    _Disposed = true;
  }

  protected abstract void Free();
}