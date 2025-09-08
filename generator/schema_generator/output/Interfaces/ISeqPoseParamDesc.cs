using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISeqPoseParamDesc : ISchemaClass {

  public ref CBufferString Name { get; }
  
  public ref float Start { get; }
  
  public ref float End { get; }
  
  public ref float Loop { get; }
  
  public ref bool Looping { get; }
  
}