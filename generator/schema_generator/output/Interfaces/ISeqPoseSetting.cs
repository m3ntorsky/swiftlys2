using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISeqPoseSetting : ISchemaClass {

  public ref CBufferString PoseParameter { get; }
  
  public ref CBufferString Attachment { get; }
  
  public ref CBufferString ReferenceSequence { get; }
  
  public ref float Value { get; }
  
  public ref bool X { get; }
  
  public ref bool Y { get; }
  
  public ref bool Z { get; }
  
  public ref int Type { get; }
  
}