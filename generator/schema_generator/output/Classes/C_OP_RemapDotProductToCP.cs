using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapDotProductToCP : CParticleFunctionPreEmission, IC_OP_RemapDotProductToCP {

  public C_OP_RemapDotProductToCP(nint handle) : base(handle) {
  }

  public ref int InputCP1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDC012AAEA0CCAE3F));
  }
  public ref int InputCP2 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDC012AAEA1CCAFD2));
  }
  public ref int OutputCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDC012AAE50DF5703));
  }
  public ref int OutVectorField {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDC012AAEF9041E74));
  }
  public IParticleCollectionFloatInput InputMin {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xDC012AAEE88A0D0F));
  }
  public IParticleCollectionFloatInput InputMax {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xDC012AAED6766901));
  }
  public IParticleCollectionFloatInput OutputMin {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xDC012AAE5F8D7716));
  }
  public IParticleCollectionFloatInput OutputMax {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xDC012AAE51A0E8C4));
  }


}