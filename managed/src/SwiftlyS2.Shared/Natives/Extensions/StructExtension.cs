using SwiftlyS2.Shared.Natives.Structs;

namespace SwiftlyS2.Shared.Natives.Extensions;

public static class StructExtension {
  public static Vector ToSdkVector(this System.Numerics.Vector3 from) {
    return new Vector(from.X, from.Y, from.Z);
  }
}
