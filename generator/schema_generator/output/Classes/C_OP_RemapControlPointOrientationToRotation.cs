using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapControlPointOrientationToRotation : CParticleFunctionOperator, IC_OP_RemapControlPointOrientationToRotation {

  public C_OP_RemapControlPointOrientationToRotation(nint handle) : base(handle) {
  }

  public ref int CP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x2CE44E90EB661472));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x2CE44E90E5729606));
  }
  public ref float OffsetRot {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2CE44E90B414F849));
  }
  public ref int Component {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x2CE44E90BFD0952C));
  }


}