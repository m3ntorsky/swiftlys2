using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_InheritFromParentParticles : CParticleFunctionInitializer, IC_INIT_InheritFromParentParticles {

  public C_INIT_InheritFromParentParticles(nint handle) : base(handle) {
  }

  public ref float Scale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF97C3548B731A42F));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xF97C3548E5729606));
  }
  public ref int Increment {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF97C35482359F182));
  }
  public ref bool RandomDistribution {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF97C3548830F6B38));
  }
  public ref int RandomSeed {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xF97C35486388F067));
  }


}