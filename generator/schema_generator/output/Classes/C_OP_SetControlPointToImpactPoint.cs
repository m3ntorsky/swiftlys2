using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_SetControlPointToImpactPoint : CParticleFunctionPreEmission, IC_OP_SetControlPointToImpactPoint {

  public C_OP_SetControlPointToImpactPoint(nint handle) : base(handle) {
  }

  public C_OP_SetControlPointToImpactPoint(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int CPOut {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5ED2C481BAE50826));
  }
  public ref int CPIn {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5ED2C481CAF7E91D));
  }
  public ref float UpdateRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5ED2C4812701581C));
  }
  public IParticleCollectionFloatInput TraceLength {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0x5ED2C481F5A5DE40));
  }
  public ref float StartOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5ED2C48169A449AA));
  }
  public ref float Offset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5ED2C4817F14BA34));
  }
  public ref Vector TraceDir {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x5ED2C481B3F09745));
  }
  public ISchemaFixedString CollisionGroupName {
    get => new SchemaFixedString(_Handle + Schema.GetOffset(0x5ED2C481D58A3195));
  }
  public ref ParticleTraceSet_t TraceSet {
    get => ref _Handle.AsRef<ParticleTraceSet_t>(Schema.GetOffset(0x5ED2C481BD26C5B2));
  }
  public ref bool SetToEndpoint {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5ED2C481B96F6E13));
  }
  public ref bool TraceToClosestSurface {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5ED2C4816BEE8BDD));
  }
  public ref bool IncludeWater {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5ED2C481EB8D4646));
  }


}