using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSosGroupMatchPattern : CSosGroupBranchPattern, ISosGroupMatchPattern {

  public CSosGroupMatchPattern(nint handle) : base(handle) {
  }

  public CSosGroupMatchPattern(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString MatchSoundEventName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xC21A80F95E75165C));
  }
  public ref CUtlString MatchSoundEventSubString {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xC21A80F92FBB6296));
  }
  public ref float EntIndex {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC21A80F9CD8F80C8));
  }
  public ref float Opvar {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC21A80F954283361));
  }
  public ref CUtlString OpvarString {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xC21A80F9528828B2));
  }


}