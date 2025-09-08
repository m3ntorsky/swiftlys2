using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFollowTargetUpdateNode : CUnaryUpdateNode, IFollowTargetUpdateNode {

  public CFollowTargetUpdateNode(nint handle) : base(handle) {
  }

  public IFollowTargetOpFixedSettings_t OpFixedData {
    get => new FollowTargetOpFixedSettings_t(_Handle + Schema.GetOffset(0x2A45E9CB6960AF8C));
  }
  public IAnimParamHandle ParameterPosition {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x2A45E9CBDA71CD41));
  }
  public IAnimParamHandle ParameterOrientation {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x2A45E9CB1320E9C8));
  }


}