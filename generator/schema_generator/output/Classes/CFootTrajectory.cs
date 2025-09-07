using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFootTrajectory : SchemaClass, IFootTrajectory {

  public CFootTrajectory(nint handle) : base(handle) {
  }

  public CFootTrajectory(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector Offset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x193297AFFE159136));
  }
  public ref float RotationOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x193297AFF811C66E));
  }
  public ref float Progression {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x193297AF4C9E1656));
  }


}