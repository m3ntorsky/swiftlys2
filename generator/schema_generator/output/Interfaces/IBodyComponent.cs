using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBodyComponent : IEntityComponent {

  
  public IGameSceneNode SceneNode { get; }
  
  public INetworkVarChainer __m_pChainEntity { get; }
}