using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class COrientationWarpUpdateNode : CUnaryUpdateNode, IOrientationWarpUpdateNode {

  public COrientationWarpUpdateNode(nint handle) : base(handle) {
  }

  public COrientationWarpUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref OrientationWarpMode_t Mode {
    get => ref _Handle.AsRef<OrientationWarpMode_t>(Schema.GetOffset(0xD75D3B631050A633));
  }
  public IAnimParamHandle TargetParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xD75D3B63D85B45EB));
  }
  public IAnimParamHandle TargetPositionParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xD75D3B63550BBF72));
  }
  public IAnimParamHandle FallbackTargetPositionParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xD75D3B63E8F94D78));
  }
  public ref OrientationWarpTargetOffsetMode_t TargetOffsetMode {
    get => ref _Handle.AsRef<OrientationWarpTargetOffsetMode_t>(Schema.GetOffset(0xD75D3B63487B121D));
  }
  public ref float TargetOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD75D3B6354596915));
  }
  public IAnimParamHandle TargetOffsetParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xD75D3B63BA3F5E7A));
  }
  public IAnimInputDamping Damping {
    get => new CAnimInputDamping(_Handle + Schema.GetOffset(0xD75D3B6315440FB5));
  }
  public ref OrientationWarpRootMotionSource_t RootMotionSource {
    get => ref _Handle.AsRef<OrientationWarpRootMotionSource_t>(Schema.GetOffset(0xD75D3B6398FEE9D7));
  }
  public ref float MaxRootMotionScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD75D3B6342F361DD));
  }
  public ref bool EnablePreferredRotationDirection {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD75D3B63AA7BFB6E));
  }
  public ref AnimValueSource PreferredRotationDirection {
    get => ref _Handle.AsRef<AnimValueSource>(Schema.GetOffset(0xD75D3B633BBCBFE8));
  }
  public ref float PreferredRotationThreshold {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD75D3B6397A825DD));
  }


}