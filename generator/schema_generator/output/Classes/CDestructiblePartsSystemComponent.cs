using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDestructiblePartsSystemComponent : SchemaClass, IDestructiblePartsSystemComponent {

  public CDestructiblePartsSystemComponent(nint handle) : base(handle) {
  }

  public INetworkVarChainer __m_pChainEntity {
    get => new CNetworkVarChainer(_Handle + Schema.GetOffset(0xD5CCC0B6F63F0E7D));
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