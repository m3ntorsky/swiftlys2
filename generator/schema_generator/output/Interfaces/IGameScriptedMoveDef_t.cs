using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IGameScriptedMoveDef_t : ISchemaClass {

  public ref Vector DestOffset { get; }
  
  public ref CHandle<CBaseEntity> DestEntity { get; }
  
  public ref QAngle Dest { get; }
  
  public ref float Duration { get; }
  
  public ref float AngRate { get; }
  
  public ref float MoveSpeed { get; }
  
  public ref bool AimDisabled { get; }
  
  public ref bool IgnoreRotation { get; }
  
  public ref ForcedCrouchState_t ForcedCrouchState { get; }
  
}