using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBreakable : CBaseModelEntity, IBreakable {

  public CBreakable(nint handle) : base(handle) {
  }

  public ref Materials Material {
    get => ref _Handle.AsRef<Materials>(Schema.GetOffset(0xC5CDE3293BBD7CE0));
  }
  public ref CHandle<CBaseEntity> Breaker {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0xC5CDE329161604FD));
  }
  public ref Explosions Explosion {
    get => ref _Handle.AsRef<Explosions>(Schema.GetOffset(0xC5CDE3298FD2AD60));
  }
  public ISchemaUntypedField SpawnObject {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC5CDE329D32D7547));
  }
  public ref float PressureDelay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC5CDE3294852270B));
  }
  public ref int MinHealthDmg {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xC5CDE32991F14A4A));
  }
  public ISchemaUntypedField PropData {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC5CDE32958671088));
  }
  public ref float ImpactEnergyScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC5CDE329C66BAC1B));
  }
  public ref EOverrideBlockLOS_t OverrideBlockLOS {
    get => ref _Handle.AsRef<EOverrideBlockLOS_t>(Schema.GetOffset(0xC5CDE329E9152440));
  }
  public IEntityIOOutput OnBreak {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xC5CDE32946BFEC4F));
  }
  public ISchemaUntypedField OnHealthChanged {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC5CDE329EAC125B2));
  }
  public ref PerformanceMode_t PerformanceMode {
    get => ref _Handle.AsRef<PerformanceMode_t>(Schema.GetOffset(0xC5CDE329C12B4C52));
  }
  public ref CHandle<CBasePlayerPawn> PhysicsAttacker {
    get => ref _Handle.AsRef<CHandle<CBasePlayerPawn>>(Schema.GetOffset(0xC5CDE3297A5EB877));
  }
  public IGameTime_t LastPhysicsInfluenceTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xC5CDE3295B5C0E32));
  }

  public void CPropDataComponentUpdated() {
    Schema.Update(_Handle, 0xC5CDE329ACBC1DDE);
  }
}