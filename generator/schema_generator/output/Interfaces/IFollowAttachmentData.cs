using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFollowAttachmentData : ISchemaClass {

  public ref int BoneIndex { get; }
  
  public IAttachmentHandle_t AttachmentHandle { get; }
  
}