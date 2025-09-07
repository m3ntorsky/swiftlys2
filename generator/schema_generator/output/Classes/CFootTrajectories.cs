using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFootTrajectories : SchemaClass, IFootTrajectories {

  public CFootTrajectories(nint handle) : base(handle) {
  }

  public CFootTrajectories(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CFootTrajectory > Trajectories {
    get => ref _Handle.AsRef<CUtlVector< CFootTrajectory >>(Schema.GetOffset(0x5D019D277964C78C));
  }


}