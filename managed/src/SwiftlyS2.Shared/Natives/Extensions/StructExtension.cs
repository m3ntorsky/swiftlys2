using SwiftlyS2.Shared.Natives;

namespace SwiftlyS2.Shared.Natives;

public static class StructExtension {
  public static Vector ToGameVector(this System.Numerics.Vector3 from) {
    return new Vector(from.X, from.Y, from.Z);
  }
}
