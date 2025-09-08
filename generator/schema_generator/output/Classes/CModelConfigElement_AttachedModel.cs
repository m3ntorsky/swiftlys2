using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CModelConfigElement_AttachedModel : CModelConfigElement, IModelConfigElement_AttachedModel {

  public CModelConfigElement_AttachedModel(nint handle) : base(handle) {
  }

  public ref CUtlString InstanceName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x82D04A99643AE8F9));
  }
  public ref CUtlString EntityClass {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x82D04A995BEE014A));
  }
  public ref CStrongHandle<InfoForResourceTypeCModel> Model {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeCModel>>(Schema.GetOffset(0x82D04A99E100C814));
  }
  public ref Vector Offset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x82D04A99FE159136));
  }
  public ref QAngle AngOffset {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x82D04A9971C0EE4F));
  }
  public ref CUtlString AttachmentName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x82D04A999CFCA76B));
  }
  public ref CUtlString LocalAttachmentOffsetName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x82D04A9934391DC1));
  }
  public ref ModelConfigAttachmentType_t AttachmentType {
    get => ref _Handle.AsRef<ModelConfigAttachmentType_t>(Schema.GetOffset(0x82D04A99EB2E2AA0));
  }
  public ref bool BoneMergeFlex {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x82D04A998B6BC852));
  }
  public ref bool UserSpecifiedColor {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x82D04A9952ADA09B));
  }
  public ref bool UserSpecifiedMaterialGroup {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x82D04A99DBD8A8C4));
  }
  public ref bool AcceptParentMaterialDrivenDecals {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x82D04A996A2FFA80));
  }
  public ref CUtlString BodygroupOnOtherModels {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x82D04A994536DE3B));
  }
  public ref CUtlString MaterialGroupOnOtherModels {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x82D04A9959E9920E));
  }


}