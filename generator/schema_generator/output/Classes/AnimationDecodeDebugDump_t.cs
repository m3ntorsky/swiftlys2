using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AnimationDecodeDebugDump_t : SchemaClass, IAnimationDecodeDebugDump_t {

  public AnimationDecodeDebugDump_t(nint handle) : base(handle) {
  }

  public AnimationDecodeDebugDump_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref AnimationProcessingType_t ProcessingType {
    get => ref _Handle.AsRef<AnimationProcessingType_t>(Schema.GetOffset(0xA584797F5F059FB6));
  }
  public ref CUtlVector< AnimationDecodeDebugDumpElement_t > Elems {
    get => ref _Handle.AsRef<CUtlVector< AnimationDecodeDebugDumpElement_t >>(Schema.GetOffset(0xA584797F3F2FC92B));
  }


}