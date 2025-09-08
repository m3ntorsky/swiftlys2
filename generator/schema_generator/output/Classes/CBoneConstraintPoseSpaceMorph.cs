using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBoneConstraintPoseSpaceMorph : CBoneConstraintBase, IBoneConstraintPoseSpaceMorph {

  public CBoneConstraintPoseSpaceMorph(nint handle) : base(handle) {
  }

  public ref CUtlString BoneName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x6ECAD65A7559AC1F));
  }
  public ref CUtlString AttachmentName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x6ECAD65A7B86DB7C));
  }
  public ref CUtlVector<CUtlString> OutputMorph {
    get => ref _Handle.AsRef<CUtlVector<CUtlString>>(Schema.GetOffset(0x6ECAD65ADC9A8262));
  }
  public ref CUtlVector InputList {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x6ECAD65A15EB8D83));
  }
  public ref bool Clamp {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6ECAD65A84C7929C));
  }


}