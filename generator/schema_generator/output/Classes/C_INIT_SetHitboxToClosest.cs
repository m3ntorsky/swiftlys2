using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_SetHitboxToClosest : CParticleFunctionInitializer, IC_INIT_SetHitboxToClosest {

  public C_INIT_SetHitboxToClosest(nint handle) : base(handle) {
  }

  public C_INIT_SetHitboxToClosest(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x10F3322C3F31A6BD));
  }
  public ref int DesiredHitbox {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x10F3322CFD09531B));
  }
  public IParticleCollectionVecInput HitBoxScale {
    get => new CParticleCollectionVecInput(_Handle + Schema.GetOffset(0x10F3322C58EE3FB7));
  }
  public ISchemaFixedString HitboxSetName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0x10F3322C6A21BB0E));
  }
  public ref bool UseBones {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x10F3322C10D1938B));
  }
  public ref bool UseClosestPointOnHitbox {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x10F3322CA983A934));
  }
  public ref ClosestPointTestType_t TestType {
    get => ref _Handle.AsRef<ClosestPointTestType_t>(Schema.GetOffset(0x10F3322CEB021501));
  }
  public IParticleCollectionFloatInput HybridRatio {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x10F3322CC2A9455C));
  }
  public ref bool UpdatePosition {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x10F3322C65B36E87));
  }


}