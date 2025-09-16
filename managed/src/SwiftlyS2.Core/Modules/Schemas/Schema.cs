using SwiftlyS2.Core.Natives;

namespace SwiftlyS2.Core.Schemas;

internal static class Schema {
  
  public static int GetOffset(ulong hash) {
    return NativeSchema.GetOffset(hash);
  }

  public static void Update(nint handle, ulong hash) {
    NativeSchema.SetStateChanged(handle, hash);
  }

}