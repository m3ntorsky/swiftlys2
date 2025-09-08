using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPlayer_MovementServices_Humanoid : IPlayer_MovementServices {

  public ref float StepSoundTime { get; }
  
  public ref float FallVelocity { get; }
  
  public ref bool InCrouch { get; }
  
  public ref uint CrouchState { get; }
  
  public IGameTime_t CrouchTransitionStartTime { get; }
  
  public ref bool Ducked { get; }
  
  public ref bool Ducking { get; }
  
  public ref bool InDuckJump { get; }
  
  public ref Vector GroundNormal { get; }
  
  public ref float SurfaceFriction { get; }
  
  public ref CUtlStringToken SurfaceProps { get; }
  
  public ref int Stepside { get; }
  
  public ref Vector SmoothedVelocity { get; }
  
}