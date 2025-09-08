using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_Diffusion : CParticleFunctionOperator, IC_OP_Diffusion {

  public C_OP_Diffusion(nint handle) : base(handle) {
  }

  public ref float RadiusScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2D5ABEF4A7A20159));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x2D5ABEF4E5729606));
  }
  public ref int VoxelGridResolution {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x2D5ABEF45AA7D7ED));
  }


}