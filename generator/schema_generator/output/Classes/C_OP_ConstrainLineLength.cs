using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_ConstrainLineLength : CParticleFunctionConstraint, IC_OP_ConstrainLineLength {

  public C_OP_ConstrainLineLength(nint handle) : base(handle) {
  }

  public ref float MinDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x50EFFC4492BCAD06));
  }
  public ref float MaxDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x50EFFC4498893360));
  }


}