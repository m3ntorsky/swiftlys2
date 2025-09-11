using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimFoot : ISchemaClass {

  
  public ref CUtlString Name { get; }
  
  public ref Vector BallOffset { get; }
  
  public ref Vector HeelOffset { get; }
  
  public ref int AnkleBoneIndex { get; }
  
  public ref int ToeBoneIndex { get; }
}