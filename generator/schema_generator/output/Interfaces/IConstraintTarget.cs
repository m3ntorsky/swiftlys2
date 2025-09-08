using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IConstraintTarget : ISchemaClass {

  public ref Quaternion Offset { get; }
  
  public ref Vector Offset { get; }
  
  public ref uint BoneHash { get; }
  
  public ref CUtlString Name { get; }
  
  public ref float Weight { get; }
  
  public ref bool IsAttachment { get; }
  
}