using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlayerPawnComponent : SchemaClass, IPlayerPawnComponent {

  public CPlayerPawnComponent(nint handle) : base(handle) {
  }

  public CPlayerPawnComponent(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public INetworkVarChainer __m_pChainEntity {
    get => new CNetworkVarChainer(_Handle + Schema.GetOffset(0x8B6AC9BCF63F0E7D));
  }


}