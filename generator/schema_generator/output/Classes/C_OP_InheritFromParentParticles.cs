using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_InheritFromParentParticles : CParticleFunctionOperator, IC_OP_InheritFromParentParticles {

  public C_OP_InheritFromParentParticles(nint handle) : base(handle) {
  }

  public C_OP_InheritFromParentParticles(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Scale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4310722BB731A42F));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x4310722BE5729606));
  }
  public ref int Increment {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4310722B2359F182));
  }
  public ref bool RandomDistribution {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4310722B830F6B38));
  }


}