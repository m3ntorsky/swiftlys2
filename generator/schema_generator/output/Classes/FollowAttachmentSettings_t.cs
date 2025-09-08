using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FollowAttachmentSettings_t : SchemaClass, IFollowAttachmentSettings_t {

  public FollowAttachmentSettings_t(nint handle) : base(handle) {
  }

  public IAnimAttachment Attachment {
    get => new CAnimAttachment(_Handle + Schema.GetOffset(0x94FFC64B2C5CA308));
  }
  public ref int BoneIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x94FFC64B6AFA4155));
  }
  public IAttachmentHandle_t AttachmentHandle {
    get => new AttachmentHandle_t(_Handle + Schema.GetOffset(0x94FFC64BA203035E));
  }
  public ref bool MatchTranslation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x94FFC64B96FCC779));
  }
  public ref bool MatchRotation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x94FFC64BA4FB561C));
  }


}