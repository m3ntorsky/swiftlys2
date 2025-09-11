using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPropDoorRotating : IBasePropDoor {

  
  public ref Vector Axis { get; }
  
  public ref float Distance { get; }
  
  public ref PropDoorRotatingSpawnPos_t SpawnPosition { get; }
  
  public ref PropDoorRotatingOpenDirection_e OpenDirection { get; }
  
  public ref PropDoorRotatingOpenDirection_e CurrentOpenDirection { get; }
  
  public ref float AjarAngle { get; }
  
  public ref QAngle RotationAjarDeprecated { get; }
  
  public ref QAngle RotationClosed { get; }
  
  public ref QAngle RotationOpenForward { get; }
  
  public ref QAngle RotationOpenBack { get; }
  
  public ref QAngle Goal { get; }
  
  public ref Vector ForwardBoundsMin { get; }
  
  public ref Vector ForwardBoundsMax { get; }
  
  public ref Vector BackBoundsMin { get; }
  
  public ref Vector BackBoundsMax { get; }
  
  public ref bool AjarDoorShouldntAlwaysOpen { get; }
  
  public ref CHandle<CEntityBlocker> EntityBlocker { get; }
}