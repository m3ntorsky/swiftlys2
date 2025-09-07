using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlayerControllerComponent : SchemaClass, IPlayerControllerComponent {

  public CPlayerControllerComponent(nint handle) : base(handle) {
  }

  public CPlayerControllerComponent(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public INetworkVarChainer __m_pChainEntity {
    get => new CNetworkVarChainer(_Handle + Schema.GetOffset(0xC96CF122F63F0E7D));
  }


}