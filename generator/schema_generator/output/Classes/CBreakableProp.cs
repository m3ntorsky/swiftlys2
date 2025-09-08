using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBreakableProp : CBaseProp, IBreakableProp {

  public CBreakableProp(nint handle) : base(handle) {
  }

  public IEntityIOOutput OnStartDeath {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xD9F5AF34F3ED4C8E));
  }
  public IEntityIOOutput OnBreak {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xD9F5AF3446BFEC4F));
  }
  public ISchemaUntypedField OnHealthChanged {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD9F5AF34EAC125B2));
  }
  public IEntityIOOutput OnTakeDamage {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xD9F5AF34CC9E35D2));
  }
  public ref float ImpactEnergyScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD9F5AF34C66BAC1B));
  }
  public ref int MinHealthDmg {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD9F5AF3491F14A4A));
  }
  public ref QAngle PreferredCarryAngles {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0xD9F5AF349778BEE9));
  }
  public ref float PressureDelay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD9F5AF344852270B));
  }
  public ref float DefBurstScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD9F5AF348D3953C6));
  }
  public ref Vector DefBurstOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD9F5AF341E951FF1));
  }
  public CHandle<IBaseEntity> Breaker {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0xD9F5AF34161604FD));
  }
  public ref PerformanceMode_t PerformanceMode {
    get => ref _Handle.AsRef<PerformanceMode_t>(Schema.GetOffset(0xD9F5AF34C12B4C52));
  }
  public IGameTime_t PreventDamageBeforeTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xD9F5AF34431B46E8));
  }
  public ref BreakableContentsType_t BreakableContentsType {
    get => ref _Handle.AsRef<BreakableContentsType_t>(Schema.GetOffset(0xD9F5AF34C332D3A2));
  }
  public ref CUtlString StrBreakableContentsPropGroupOverride {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xD9F5AF34FEDC11AB));
  }
  public ref CUtlString StrBreakableContentsParticleOverride {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xD9F5AF3461C07367));
  }
  public ref bool HasBreakPiecesOrCommands {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD9F5AF348BD56C36));
  }
  public ref float ExplodeDamage {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD9F5AF34EADCF523));
  }
  public ref float ExplodeRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD9F5AF34229BEC64));
  }
  public ref float ExplosionDelay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD9F5AF349DB4A86F));
  }
  public ref CUtlSymbolLarge ExplosionBuildupSound {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xD9F5AF34835ABA6C));
  }
  public ref CUtlSymbolLarge ExplosionCustomEffect {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xD9F5AF34BC8BEFBE));
  }
  public ref CUtlSymbolLarge ExplosionCustomSound {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xD9F5AF34E729842A));
  }
  public ref CUtlSymbolLarge ExplosionModifier {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xD9F5AF34531D2849));
  }
  public CHandle<IBasePlayerPawn> PhysicsAttacker {
    get => new CHandle<CBasePlayerPawn>(_Handle + Schema.GetOffset(0xD9F5AF347A5EB877));
  }
  public IGameTime_t LastPhysicsInfluenceTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xD9F5AF345B5C0E32));
  }
  public ref float DefaultFadeScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD9F5AF344DA9700C));
  }
  public CHandle<IBaseEntity> LastAttacker {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0xD9F5AF3465CAEF84));
  }
  public ref CUtlSymbolLarge PuntSound {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xD9F5AF34FB0FC5DB));
  }
  public ref bool UsePuntSound {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD9F5AF34BA328938));
  }
  public ref bool OriginalBlockLOS {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD9F5AF34A80D357B));
  }

  public void CPropDataComponentUpdated() {
    Schema.Update(_Handle, 0xD9F5AF34ACBC1DDE);
  }
}