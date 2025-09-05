namespace SwiftlyS2.Core.Natives.NativeObjects;

using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using SwiftlyS2.Shared.Natives;

internal abstract class AllocableNativeHandle : SafeHandleZeroOrMinusOneIsInvalid, INativeHandle {

  public bool IsValid { get => !IsInvalid; }

  protected AllocableNativeHandle(nint handle) : base(true) {
    SetHandle(handle);
  }

  public nint GetHandle()
  {
    // TODO: Might need a ref counter here?
    // but since we have already warned it as an unsafe operation, user should be responsible for leaking the raw handle.
    if (!IsValid) throw new InvalidOperationException("Trying to get a invalid handle.");
    return DangerousGetHandle();
  }

  /// <summary>
  /// For implementation to call their own native free method.
  /// </summary>
  /// <returns>Whether the handle is freed successfully.</returns>
  protected abstract bool Free();

  protected override bool ReleaseHandle()
  {
      return Free();
  }
}