using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_PlanarConstraint : CParticleFunctionConstraint, IC_OP_PlanarConstraint {

  public C_OP_PlanarConstraint(nint handle) : base(handle) {
  }

  public C_OP_PlanarConstraint(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector PointOnPlane {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1440B2AE4A5806BE));
  }
  public ref Vector PlaneNormal {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1440B2AEEAA80062));
  }
  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1440B2AE3F31A6BD));
  }
  public ref bool GlobalOrigin {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1440B2AEDF871518));
  }
  public ref bool GlobalNormal {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1440B2AE266C15DD));
  }
  public IPerParticleFloatInput RadiusScale {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0x1440B2AEA7A20159));
  }
  public IParticleCollectionFloatInput MaximumDistanceToCP {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x1440B2AE91B48FEA));
  }
  public ref bool UseOldCode {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1440B2AEB7886300));
  }


}