using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEntityFlame : CBaseEntity, IEntityFlame {

  public CEntityFlame(nint handle) : base(handle) {
  }

  public ref float Size {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x386F19944CF0EBC6));
  }
  public ref bool UseHitboxes {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x386F19948C5BFEBE));
  }
  public ref int NumHitboxFires {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x386F199457E3580B));
  }
  public ref float HitboxFireScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x386F19942AD17519));
  }
  public IGameTime_t Lifetime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x386F199439B35564));
  }
  public CHandle<IBaseEntity> Attacker {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x386F199468573D54));
  }
  public ref float DirectDamagePerSecond {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x386F199482A435AE));
  }
  public ref int CustomDamageType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x386F1994E0A58F6E));
  }

  public void EntAttachedUpdated() {
    Schema.Update(_Handle, 0x386F199409F89DF0);
  }
  public void CheapEffectUpdated() {
    Schema.Update(_Handle, 0x386F1994DF421B51);
  }
}