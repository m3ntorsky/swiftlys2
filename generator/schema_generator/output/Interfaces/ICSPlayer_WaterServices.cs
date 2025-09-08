using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICSPlayer_WaterServices : IPlayer_WaterServices {

  public IGameTime_t NextDrownDamageTime { get; }
  
  public ref int DrownDmgRate { get; }
  
  public IGameTime_t AirFinishedTime { get; }
  
  public ref float WaterJumpTime { get; }
  
  public ref Vector WaterJumpVel { get; }
  
  public ref float SwimSoundTime { get; }
  
}