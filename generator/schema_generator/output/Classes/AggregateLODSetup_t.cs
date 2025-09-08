using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AggregateLODSetup_t : SchemaClass, IAggregateLODSetup_t {

  public AggregateLODSetup_t(nint handle) : base(handle) {
  }

  public ref Vector LODOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xA931690332EC7486));
  }
  public ref float MaxObjectScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA9316903D0DAF878));
  }
  public ref CUtlVector<float> SwitchDistances {
    get => ref _Handle.AsRef<CUtlVector<float>>(Schema.GetOffset(0xA9316903E49F3FC3));
  }


}