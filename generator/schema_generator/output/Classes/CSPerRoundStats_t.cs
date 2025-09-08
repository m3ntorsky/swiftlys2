using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSPerRoundStats_t : SchemaClass, ISPerRoundStats_t {

  public CSPerRoundStats_t(nint handle) : base(handle) {
  }



  public void KillsUpdated() {
    Schema.Update(_Handle, 0xA16B85EA0E456FE5);
  }
  public void DeathsUpdated() {
    Schema.Update(_Handle, 0xA16B85EAAF18870F);
  }
  public void AssistsUpdated() {
    Schema.Update(_Handle, 0xA16B85EAB792DB50);
  }
  public void DamageUpdated() {
    Schema.Update(_Handle, 0xA16B85EA0DEE4DB5);
  }
  public void EquipmentValueUpdated() {
    Schema.Update(_Handle, 0xA16B85EA1B2CADDD);
  }
  public void MoneySavedUpdated() {
    Schema.Update(_Handle, 0xA16B85EAC85DB77B);
  }
  public void KillRewardUpdated() {
    Schema.Update(_Handle, 0xA16B85EA9C813A23);
  }
  public void LiveTimeUpdated() {
    Schema.Update(_Handle, 0xA16B85EAD956D2F7);
  }
  public void HeadShotKillsUpdated() {
    Schema.Update(_Handle, 0xA16B85EA2C61AFF3);
  }
  public void ObjectiveUpdated() {
    Schema.Update(_Handle, 0xA16B85EA14FC52D7);
  }
  public void CashEarnedUpdated() {
    Schema.Update(_Handle, 0xA16B85EA8BEB3100);
  }
  public void UtilityDamageUpdated() {
    Schema.Update(_Handle, 0xA16B85EAC91A82E5);
  }
  public void EnemiesFlashedUpdated() {
    Schema.Update(_Handle, 0xA16B85EA460AB70F);
  }
}