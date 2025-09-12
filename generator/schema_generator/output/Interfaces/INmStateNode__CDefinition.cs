using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmStateNode__CDefinition : INmPoseNode::CDefinition {

  
  public ref short ChildNodeIdx { get; }
  
  public ISchemaUntypedField EntryEvents { get; }
  
  public ISchemaUntypedField ExecuteEvents { get; }
  
  public ISchemaUntypedField ExitEvents { get; }
  
  public ISchemaUntypedField TimedRemainingEvents { get; }
  
  public ISchemaUntypedField TimedElapsedEvents { get; }
  
  public ref short LayerWeightNodeIdx { get; }
  
  public ref short LayerRootMotionWeightNodeIdx { get; }
  
  public ref short LayerBoneMaskNodeIdx { get; }
  
  public ref bool IsOffState { get; }
}