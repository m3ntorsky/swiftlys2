using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseToggle : IBaseModelEntity {

  
  public ref TOGGLE_STATE Toggle_state { get; }
  
  public ref float MoveDistance { get; }
  
  public ref float Wait { get; }
  
  public ref float Lip { get; }
  
  public ref bool AlwaysFireBlockedOutputs { get; }
  
  public ref Vector Position1 { get; }
  
  public ref Vector Position2 { get; }
  
  public ref QAngle MoveAng { get; }
  
  public ref QAngle Angle1 { get; }
  
  public ref QAngle Angle2 { get; }
  
  public ref float Height { get; }
  
  public ref CHandle<CBaseEntity> Activator { get; }
  
  public ref Vector FinalDest { get; }
  
  public ref QAngle FinalAngle { get; }
  
  public ref int MovementType { get; }
  
  public ref CUtlSymbolLarge Master { get; }
}