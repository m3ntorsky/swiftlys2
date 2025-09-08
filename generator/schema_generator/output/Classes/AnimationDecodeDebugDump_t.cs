using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AnimationDecodeDebugDump_t : SchemaClass, IAnimationDecodeDebugDump_t {

  public AnimationDecodeDebugDump_t(nint handle) : base(handle) {
  }

  public ref AnimationProcessingType_t ProcessingType {
    get => ref _Handle.AsRef<AnimationProcessingType_t>(Schema.GetOffset(0xA584797F5F059FB6));
  }
  public ref CUtlVector Elems {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA584797F3F2FC92B));
  }


}