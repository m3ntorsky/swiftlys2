using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmLayerBlendNode__CDefinition : INmPoseNode::CDefinition {

  
  public ref short BaseNodeIdx { get; }
  
  public ref bool OnlySampleBaseRootMotion { get; }
  
  public ISchemaUntypedField LayerDefinition { get; }
}