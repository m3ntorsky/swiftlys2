using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerPush : IBaseTrigger {

  
  public ref QAngle PushEntitySpace { get; }
  
  public ref Vector PushDirEntitySpace { get; }
  
  public ref bool TriggerOnStartTouch { get; }
  
  public ref bool UsePathSimple { get; }
  
  public ref CUtlSymbolLarge PathSimpleName { get; }
  
  public IPathSimple PathSimple { get; }
  
  public ref uint SplinePushType { get; }
}