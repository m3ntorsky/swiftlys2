using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_SequenceFromCP : CParticleFunctionInitializer, IC_INIT_SequenceFromCP {

  public C_INIT_SequenceFromCP(nint handle) : base(handle) {
  }

  public ref bool KillUnused {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC62FB07C81506527));
  }
  public ref bool RadiusScale {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC62FB07CBBCB728B));
  }
  public ref int CP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC62FB07CEB661472));
  }
  public ref Vector Offset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xC62FB07CBD25CC2A));
  }


}