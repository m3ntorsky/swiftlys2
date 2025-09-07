using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapDensityToVector : CParticleFunctionOperator, IC_OP_RemapDensityToVector {

  public C_OP_RemapDensityToVector(nint handle) : base(handle) {
  }

  public C_OP_RemapDensityToVector(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float RadiusScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x81794CB4A7A20159));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x81794CB4E5729606));
  }
  public ref float DensityMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x81794CB4B4D8467B));
  }
  public ref float DensityMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x81794CB4AAC31C05));
  }
  public ref Vector OutputMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x81794CB42EFED678));
  }
  public ref Vector OutputMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x81794CB4451280D2));
  }
  public ref bool UseParentDensity {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x81794CB40FE31F64));
  }
  public ref int VoxelGridResolution {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x81794CB45AA7D7ED));
  }


}