using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class IKTargetSettings_t : SchemaClass, IIKTargetSettings_t {

  public IKTargetSettings_t(nint handle) : base(handle) {
  }

  public ref IKTargetSource TargetSource {
    get => ref _Handle.AsRef<IKTargetSource>(Schema.GetOffset(0xE4055546D23809BD));
  }
  public IIKBoneNameAndIndex_t Bone {
    get => new IKBoneNameAndIndex_t(_Handle + Schema.GetOffset(0xE4055546193FC60F));
  }
  public IAnimParamID AnimgraphParameterNamePosition {
    get => new AnimParamID(_Handle + Schema.GetOffset(0xE4055546D9047CE3));
  }
  public IAnimParamID AnimgraphParameterNameOrientation {
    get => new AnimParamID(_Handle + Schema.GetOffset(0xE4055546C162E1CA));
  }
  public ref IKTargetCoordinateSystem TargetCoordSystem {
    get => ref _Handle.AsRef<IKTargetCoordinateSystem>(Schema.GetOffset(0xE40555469BF14938));
  }


}