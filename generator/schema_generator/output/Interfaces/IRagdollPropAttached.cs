using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRagdollPropAttached : IRagdollProp {

  public ref uint BoneIndexAttached { get; }
  
  public ref uint RagdollAttachedObjectIndex { get; }
  
  public ref Vector AttachmentPointBoneSpace { get; }
  
  public ref Vector AttachmentPointRagdollSpace { get; }
  
  public ref bool ShouldDetach { get; }
  
  public ref bool ShouldDeleteAttachedActivationRecord { get; }
  
}