using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmAnimationPoseNode__CDefinition : CNmPoseNode::CDefinition, INmAnimationPoseNode__CDefinition {

  public CNmAnimationPoseNode__CDefinition(nint handle) : base(handle) {
  }

  public ref short PoseTimeValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xAEB5DD4EE17A4AC5));
  }
  public ref short DataSlotIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xAEB5DD4EB1C15B68));
  }
  public ISchemaUntypedField InputTimeRemapRange {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xAEB5DD4EE53BDBD4));
  }
  public ref float UserSpecifiedTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xAEB5DD4E0D7319E7));
  }
  public ref bool UseFramesAsInput {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAEB5DD4EF0C41386));
  }


}