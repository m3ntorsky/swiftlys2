using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Step_FollowEntity : CPulseCell_BaseFlow, IPulseCell_Step_FollowEntity {

  public CPulseCell_Step_FollowEntity(nint handle) : base(handle) {
  }

  public ref CUtlString ParamBoneOrAttachName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x75FAF4A9B89867BB));
  }
  public ref CUtlString ParamBoneOrAttachNameChild {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x75FAF4A902011093));
  }


}