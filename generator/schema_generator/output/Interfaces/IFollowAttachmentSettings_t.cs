using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFollowAttachmentSettings_t : ISchemaClass {

  
  public IAnimAttachment Attachment { get; }
  
  public ref int BoneIndex { get; }
  
  public IAttachmentHandle_t AttachmentHandle { get; }
  
  public ref bool MatchTranslation { get; }
  
  public ref bool MatchRotation { get; }
}