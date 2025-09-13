using SwiftlyS2.Natives;

namespace SwiftlyS2.Core.Schemas;

internal static class Schema {

  public static int GetSize(ulong hash) {
    return 0;
  }

  public static int GetOffset(ulong hash) {
    NativeSchema.GetOffset(hash);
    return 0;
  }

  public static void Update(nint handle, ulong hash) {

  }

}