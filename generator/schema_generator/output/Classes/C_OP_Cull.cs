using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_Cull : CParticleFunctionOperator, IC_OP_Cull {

  public C_OP_Cull(nint handle) : base(handle) {
  }

  public ref float CullPerc {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD1E3C83568069ED3));
  }
  public ref float CullStart {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD1E3C835AB265851));
  }
  public ref float CullEnd {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD1E3C835B8217F50));
  }
  public ref float CullExp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD1E3C835BFF46C4A));
  }


}