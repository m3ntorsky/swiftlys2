namespace SwiftlyS2.Shared.Natives;

using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using SwiftlyS2.Shared.Natives;

public abstract class AllocableNativeHandle : SafeHandleZeroOrMinusOneIsInvalid, INativeHandle {

  public bool IsValid { get => !IsInvalid; }

  protected AllocableNativeHandle(nint handle, bool ownsHandle) : base(ownsHandle) {
    SetHandle(handle);
  }

  public nint GetHandle()
  {
    if (!IsValid) throw new InvalidOperationException("Trying to get a invalid handle.");
    return DangerousGetHandle();
  }

  protected abstract bool Free();

  protected override bool ReleaseHandle()
  {
      return Free();
  }
}