using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapVectortoCP : CParticleFunctionOperator, IC_OP_RemapVectortoCP {

  public C_OP_RemapVectortoCP(nint handle) : base(handle) {
  }

  public ref int OutControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xADC661D7D021D73F));
  }
  public IParticleAttributeIndex_t FieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xADC661D7AE775669));
  }
  public ref int ParticleNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xADC661D712F26402));
  }


}