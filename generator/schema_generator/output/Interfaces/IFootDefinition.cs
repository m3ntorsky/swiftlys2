using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootDefinition : ISchemaClass {

  
  public ref CUtlString Name { get; }
  
  public ref CUtlString AnkleBoneName { get; }
  
  public ref CUtlString ToeBoneName { get; }
  
  public ref Vector BallOffset { get; }
  
  public ref Vector HeelOffset { get; }
  
  public ref float FootLength { get; }
  
  public ref float BindPoseDirectionMS { get; }
  
  public ref float TraceHeight { get; }
  
  public ref float TraceRadius { get; }
}