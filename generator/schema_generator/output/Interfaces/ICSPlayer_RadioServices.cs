using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayer_RadioServices : IPlayerPawnComponent {

  
  public IGameTime_t GotHostageTalkTimer { get; }
  
  public IGameTime_t DefusingTalkTimer { get; }
  
  public IGameTime_t C4PlantTalkTimer { get; }
  
  public IGameTime_t RadioTokenSlots { get; }
  
  public ref bool IgnoreRadio { get; }
}