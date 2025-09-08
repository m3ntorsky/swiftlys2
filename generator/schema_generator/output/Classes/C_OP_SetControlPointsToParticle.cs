using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetControlPointsToParticle : CParticleFunctionOperator, IC_OP_SetControlPointsToParticle {

  public C_OP_SetControlPointsToParticle(nint handle) : base(handle) {
  }

  public ref int ChildGroupID {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x119EA308E3F3C965));
  }
  public ref int FirstControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x119EA30872117650));
  }
  public ref int NumControlPoints {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x119EA308551EBC4F));
  }
  public ref int FirstSourcePoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x119EA3089D7DC18E));
  }
  public ref bool SetOrientation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x119EA308E1390E37));
  }
  public ref ParticleOrientationSetMode_t OrientationMode {
    get => ref _Handle.AsRef<ParticleOrientationSetMode_t>(Schema.GetOffset(0x119EA308272947BA));
  }
  public ref ParticleParentSetMode_t SetParent {
    get => ref _Handle.AsRef<ParticleParentSetMode_t>(Schema.GetOffset(0x119EA3082D8246B7));
  }


}