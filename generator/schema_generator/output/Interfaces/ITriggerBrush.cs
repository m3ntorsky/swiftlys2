using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerBrush : IBaseModelEntity {

  
  public IEntityIOOutput OnStartTouch { get; }
  
  public IEntityIOOutput OnEndTouch { get; }
  
  public IEntityIOOutput OnUse { get; }
  
  public ref int InputFilter { get; }
  
  public ref int DontMessageParent { get; }
}