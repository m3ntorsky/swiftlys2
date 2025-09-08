using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPlayer_ObserverServices : IPlayerPawnComponent {

  public ref byte ObserverMode { get; }
  
  public CHandle<IBaseEntity> ObserverTarget { get; }
  
  public ref ObserverMode_t ObserverLastMode { get; }
  
  public ref bool ForcedObserverMode { get; }
  
}