using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Iragdoll_t : ISchemaClass {

  public ref CUtlVector List { get; }
  
  public ref CUtlVector HierarchyJoints { get; }
  
  public ref CUtlVector<int> BoneIndex { get; }
  
  public ref bool AllowStretch { get; }
  
  public ref bool Unused { get; }
  
}