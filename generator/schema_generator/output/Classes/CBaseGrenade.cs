using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseGrenade : CBaseFlex, IBaseGrenade {

  public CBaseGrenade(nint handle) : base(handle) {
  }

  public IEntityIOOutput OnPlayerPickup {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xB6ACD98FDE81BF25));
  }
  public IEntityIOOutput OnExplode {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xB6ACD98F5153ED85));
  }
  public ref bool HasWarnedAI {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB6ACD98F52149340));
  }
  public ref bool IsSmokeGrenade {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB6ACD98FD26F58DC));
  }
  public ref float WarnAITime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB6ACD98FFC4F4550));
  }
  public ISchemaUntypedField BounceSound {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xB6ACD98F060D1544));
  }
  public ref CUtlString ExplosionSound {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xB6ACD98FEA1C20EF));
  }
  public IGameTime_t NextAttack {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xB6ACD98F3DFDCDEA));
  }
  public ref CHandle<CCSPlayerPawn> OriginalThrower {
    get => ref _Handle.AsRef<CHandle<CCSPlayerPawn>>(Schema.GetOffset(0xB6ACD98F34FD45A3));
  }

  public void IsLiveUpdated() {
    Schema.Update(_Handle, 0xB6ACD98F4DBE6B1F);
  }
  public void DmgRadiusUpdated() {
    Schema.Update(_Handle, 0xB6ACD98FB9ADFB35);
  }
  public void DetonateTimeUpdated() {
    Schema.Update(_Handle, 0xB6ACD98F884102F2);
  }
  public void DamageUpdated() {
    Schema.Update(_Handle, 0xB6ACD98FDC60E53E);
  }
  public void ThrowerUpdated() {
    Schema.Update(_Handle, 0xB6ACD98FC9CF8702);
  }
}