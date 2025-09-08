using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeFollowNode_t : ISchemaClass {

  public ref ushort ParentNode { get; }
  
  public ref ushort ChildNode { get; }
  
  public ref float Weight { get; }
  
}