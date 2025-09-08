using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFootStride : SchemaClass, IFootStride {

  public CFootStride(nint handle) : base(handle) {
  }

  public IFootCycleDefinition Definition {
    get => new CFootCycleDefinition(_Handle + Schema.GetOffset(0x6093B6FA95E6F40));
  }
  public IFootTrajectories Trajectories {
    get => new CFootTrajectories(_Handle + Schema.GetOffset(0x6093B6F7964C78C));
  }


}