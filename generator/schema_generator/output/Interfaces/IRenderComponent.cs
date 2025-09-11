using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRenderComponent : IEntityComponent {

  
  public INetworkVarChainer __m_pChainEntity { get; }
  
  public ref bool IsRenderingWithViewModels { get; }
  
  public ref uint SplitscreenFlags { get; }
  
  public ref bool EnableRendering { get; }
  
  public ref bool InterpolationReadyToDraw { get; }
}