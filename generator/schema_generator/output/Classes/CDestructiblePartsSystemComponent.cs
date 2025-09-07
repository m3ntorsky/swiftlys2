using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDestructiblePartsSystemComponent : SchemaClass, IDestructiblePartsSystemComponent {

  public CDestructiblePartsSystemComponent(nint handle) : base(handle) {
  }

  public CDestructiblePartsSystemComponent(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public INetworkVarChainer __m_pChainEntity {
    get => new CNetworkVarChainer(_Handle + Schema.GetOffset(0xD5CCC0B6F63F0E7D));
  }
  public ref CUtlVector< uint16 > DamageLevelTakenByHitGroup {
    get => ref _Handle.AsRef<CUtlVector< uint16 >>(Schema.GetOffset(0xD5CCC0B67D8F9E94));
  }
  public ref CHandle< CBaseModelEntity > Owner {
    get => ref _Handle.AsRef<CHandle< CBaseModelEntity >>(Schema.GetOffset(0xD5CCC0B6F6D89572));
  }
  public ref int LastHitDamageLevel {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD5CCC0B6042B0657));
  }

  public void DamageLevelTakenByHitGroupUpdated() {
    Schema.Update(_Handle, 0xD5CCC0B67D8F9E94);
  }
  public void OwnerUpdated() {
    Schema.Update(_Handle, 0xD5CCC0B6F6D89572);
  }
  public void LastHitDamageLevelUpdated() {
    Schema.Update(_Handle, 0xD5CCC0B6042B0657);
  }
}