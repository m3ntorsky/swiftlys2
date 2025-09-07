using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class AnimationSnapshotBase_t : SchemaClass, IAnimationSnapshotBase_t {

  public AnimationSnapshotBase_t(nint handle) : base(handle) {
  }

  public AnimationSnapshotBase_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float RealTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x608F9331168EC02));
  }
  public ref matrix3x4a_t RootToWorld {
    get => ref _Handle.AsRef<matrix3x4a_t>(Schema.GetOffset(0x608F9331F80AFC0));
  }
  public ref bool BonesInWorldSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x608F933BDD22AA1));
  }
  public ref CUtlVector< uint32 > BoneSetupMask {
    get => ref _Handle.AsRef<CUtlVector< uint32 >>(Schema.GetOffset(0x608F9334B3C48C8));
  }
  public ref CUtlVector< matrix3x4a_t > BoneTransforms {
    get => ref _Handle.AsRef<CUtlVector< matrix3x4a_t >>(Schema.GetOffset(0x608F933ED000DE6));
  }
  public ref CUtlVector< float32 > FlexControllers {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0x608F9337742939B));
  }
  public ref AnimationSnapshotType_t SnapshotType {
    get => ref _Handle.AsRef<AnimationSnapshotType_t>(Schema.GetOffset(0x608F933533E5725));
  }
  public ref bool HasDecodeDump {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x608F933BECD8B97));
  }
  public IAnimationDecodeDebugDumpElement_t DecodeDump {
    get => new AnimationDecodeDebugDumpElement_t(_Handle + Schema.GetOffset(0x608F9332577A819));
  }


}