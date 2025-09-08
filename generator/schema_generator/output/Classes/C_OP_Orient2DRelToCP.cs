using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_Orient2DRelToCP : CParticleFunctionOperator, IC_OP_Orient2DRelToCP {

  public C_OP_Orient2DRelToCP(nint handle) : base(handle) {
  }

  public ref float RotOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD330A83D1EA9CDF));
  }
  public ref float SpinStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD330A8312520F26));
  }
  public ref int CP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD330A83EB661472));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xD330A83E5729606));
  }


}