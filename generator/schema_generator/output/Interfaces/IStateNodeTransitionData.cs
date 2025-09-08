using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IStateNodeTransitionData : ISchemaClass {

  public IBlendCurve Curve { get; }
  
  public ISchemaUntypedField BlendDuration { get; }
  
  public ISchemaUntypedField ResetCycleValue { get; }
  
  public ISchemaUntypedField Reset { get; }
  
  public ISchemaUntypedField ResetCycleOption { get; }
  
}