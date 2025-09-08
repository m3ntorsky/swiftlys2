using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISeqAutoLayer : ISchemaClass {

  public ref short LocalReference { get; }
  
  public ref short LocalPose { get; }
  
  public ISeqAutoLayerFlag Flags { get; }
  
  public ref float Start { get; }
  
  public ref float Peak { get; }
  
  public ref float Tail { get; }
  
  public ref float End { get; }
  
}