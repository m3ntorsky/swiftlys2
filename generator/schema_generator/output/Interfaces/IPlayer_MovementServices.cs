using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPlayer_MovementServices : IPlayerPawnComponent {

  public ref int Impulse { get; }
  
  public IInButtonState Buttons { get; }
  
  public ref ulong QueuedButtonDownMask { get; }
  
  public ref ulong QueuedButtonChangeMask { get; }
  
  public ref ulong ButtonDoublePressed { get; }
  
  public ISchemaFixedArray<uint> ButtonPressedCmdNumber { get; }
  
  public ref uint LastCommandNumberProcessed { get; }
  
  public ref ulong ToggleButtonDownMask { get; }
  
  public ref float Maxspeed { get; }
  
  public ISchemaFixedArray<float> ForceSubtickMoveWhen { get; }
  
  public ref float ForwardMove { get; }
  
  public ref float LeftMove { get; }
  
  public ref float UpMove { get; }
  
  public ref Vector LastMovementImpulses { get; }
  
  public ref QAngle LastFinishTickViewAngles { get; }
  
  public ref QAngle OldViewAngles { get; }
  
}