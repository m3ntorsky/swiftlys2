using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBodyComponent : CEntityComponent, IBodyComponent {

  public CBodyComponent(nint handle) : base(handle) {
  }

  public CBodyComponent(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IGameSceneNode SceneNode {
    get => new CGameSceneNode(_Handle + Schema.GetOffset(0x4EF2C865D7D13495));
  }
  public INetworkVarChainer __m_pChainEntity {
    get => new CNetworkVarChainer(_Handle + Schema.GetOffset(0x4EF2C865F63F0E7D));
  }


}