using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerHurt : CBaseTrigger, ITriggerHurt {

  public CTriggerHurt(nint handle) : base(handle) {
  }

  public ref float OriginalDamage {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8D02278785B50515));
  }
  public ref float Damage {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8D022787DC60E53E));
  }
  public ref float DamageCap {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8D022787AED58F86));
  }
  public IGameTime_t LastDmgTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x8D022787BF3F1360));
  }
  public ref float ForgivenessDelay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8D022787112B0E13));
  }
  public ref DamageTypes_t BitsDamageInflict {
    get => ref _Handle.AsRef<DamageTypes_t>(Schema.GetOffset(0x8D0227876F0ADA0F));
  }
  public ref int DamageModel {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8D022787076F74AD));
  }
  public ref bool NoDmgForce {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8D0227878236F03D));
  }
  public ref Vector DamageForce {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x8D022787B66401B7));
  }
  public ref bool ThinkAlways {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8D02278776BDBDDA));
  }
  public ref float HurtThinkPeriod {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8D022787C98165F1));
  }
  public IEntityIOOutput OnHurt {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x8D022787361573C1));
  }
  public IEntityIOOutput OnHurtPlayer {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x8D02278771C2F34C));
  }
  public ref CUtlVector<CHandle<CBaseEntity>> HurtEntities {
    get => ref _Handle.AsRef<CUtlVector<CHandle<CBaseEntity>>>(Schema.GetOffset(0x8D0227874E045AC3));
  }


}