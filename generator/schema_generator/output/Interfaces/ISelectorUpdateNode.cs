using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISelectorUpdateNode : IAnimUpdateNodeBase {

  
// CUtlVector< CAnimUpdateNodeRef >
  public ref CUtlVector Children { get; }
  
  public ref CUtlVector<byte> Tags { get; }
  
  public IBlendCurve BlendCurve { get; }
  
  public ISchemaUntypedField BlendTime { get; }
  
  public IAnimParamHandle Parameter { get; }
  
  public ref int TagIndex { get; }
  
  public ref SelectorTagBehavior_t TagBehavior { get; }
  
  public ref bool ResetOnChange { get; }
  
  public ref bool LockWhenWaning { get; }
  
  public ref bool SyncCyclesOnChange { get; }
}