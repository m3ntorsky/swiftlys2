using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ModelBoneFlexDriverControl_t : SchemaClass, IModelBoneFlexDriverControl_t {

  public ModelBoneFlexDriverControl_t(nint handle) : base(handle) {
  }

  public ref ModelBoneFlexComponent_t BoneComponent {
    get => ref _Handle.AsRef<ModelBoneFlexComponent_t>(Schema.GetOffset(0x7DDCB3413C2E9E9E));
  }
  public ref CUtlString FlexController {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x7DDCB341EDF88AAA));
  }
  public ref uint FlexControllerToken {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x7DDCB341996814FF));
  }
  public ref float Min {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7DDCB3413B1A5649));
  }
  public ref float Max {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7DDCB3412D06B887));
  }


}