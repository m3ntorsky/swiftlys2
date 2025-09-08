using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IModelConfigElement_AttachedModel : IModelConfigElement {

  public ref CUtlString InstanceName { get; }
  
  public ref CUtlString EntityClass { get; }
  
  public CStrongHandle<IInfoForResourceTypeCModel> Model { get; }
  
  public ref Vector Offset { get; }
  
  public ref QAngle AngOffset { get; }
  
  public ref CUtlString AttachmentName { get; }
  
  public ref CUtlString LocalAttachmentOffsetName { get; }
  
  public ref ModelConfigAttachmentType_t AttachmentType { get; }
  
  public ref bool BoneMergeFlex { get; }
  
  public ref bool UserSpecifiedColor { get; }
  
  public ref bool UserSpecifiedMaterialGroup { get; }
  
  public ref bool AcceptParentMaterialDrivenDecals { get; }
  
  public ref CUtlString BodygroupOnOtherModels { get; }
  
  public ref CUtlString MaterialGroupOnOtherModels { get; }
  
}