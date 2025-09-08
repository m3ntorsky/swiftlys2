using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDamageRecord : SchemaClass, IDamageRecord {

  public CDamageRecord(nint handle) : base(handle) {
  }

  public ref int BulletsDamage {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x14928316EEAE71A8));
  }

  public void PlayerDamagerUpdated() {
    Schema.Update(_Handle, 0x149283162F5812D9);
  }
  public void PlayerRecipientUpdated() {
    Schema.Update(_Handle, 0x14928316EB48351F);
  }
  public void PlayerControllerDamagerUpdated() {
    Schema.Update(_Handle, 0x14928316285F9023);
  }
  public void PlayerControllerRecipientUpdated() {
    Schema.Update(_Handle, 0x14928316033B0B25);
  }
  public void PlayerDamagerNameUpdated() {
    Schema.Update(_Handle, 0x149283165AB278AD);
  }
  public void PlayerRecipientNameUpdated() {
    Schema.Update(_Handle, 0x14928316E6015313);
  }
  public void DamagerXuidUpdated() {
    Schema.Update(_Handle, 0x14928316DAD4D818);
  }
  public void RecipientXuidUpdated() {
    Schema.Update(_Handle, 0x1492831684A232C2);
  }
  public void DamageUpdated() {
    Schema.Update(_Handle, 0x149283160DEE4DB5);
  }
  public void ActualHealthRemovedUpdated() {
    Schema.Update(_Handle, 0x14928316E7BBB38C);
  }
  public void NumHitsUpdated() {
    Schema.Update(_Handle, 0x149283162EC9980E);
  }
  public void LastBulletUpdateUpdated() {
    Schema.Update(_Handle, 0x14928316D5ABC11D);
  }
  public void IsOtherEnemyUpdated() {
    Schema.Update(_Handle, 0x149283164F1F40EB);
  }
  public void KillTypeUpdated() {
    Schema.Update(_Handle, 0x14928316C2ADBB11);
  }
}