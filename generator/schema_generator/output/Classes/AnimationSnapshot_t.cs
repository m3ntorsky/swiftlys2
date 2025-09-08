using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AnimationSnapshot_t : AnimationSnapshotBase_t, IAnimationSnapshot_t {

  public AnimationSnapshot_t(nint handle) : base(handle) {
  }

  public ref int EntIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xAC640D3E5558C54A));
  }
  public ref CUtlString ModelName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xAC640D3E5D35B6E1));
  }


}