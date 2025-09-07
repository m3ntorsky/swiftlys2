using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_VectorFieldSnapshot : CParticleFunctionOperator, IC_OP_VectorFieldSnapshot {

  public C_OP_VectorFieldSnapshot(nint handle) : base(handle) {
  }

  public C_OP_VectorFieldSnapshot(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4679512A3F31A6BD));
  }
  public IParticleAttributeIndex_t AttributeToWrite {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x4679512A389A3CC1));
  }
  public ref int LocalSpaceCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4679512AC8E9CB31));
  }
  public IPerParticleFloatInput Interpolation {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x4679512ACF55B987));
  }
  public IPerParticleVecInput Scale {
    get => new CPerParticleVecInput(_Handle + Schema.GetOffset(0x4679512A5F596B51));
  }
  public ref float BoundaryDampening {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4679512A6C557EF8));
  }
  public ref bool SetVelocity {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4679512A996C0A34));
  }
  public ref bool LockToSurface {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4679512A81E43C02));
  }
  public ref float GridSpacing {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4679512AB7D1BFB8));
  }


}