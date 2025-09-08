using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RandomForce : CParticleFunctionForce, IC_OP_RandomForce {

  public C_OP_RandomForce(nint handle) : base(handle) {
  }

  public ref Vector MinForce {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x4BB81519FA8D2AE2));
  }
  public ref Vector MaxForce {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x4BB815192324D8D8));
  }


}