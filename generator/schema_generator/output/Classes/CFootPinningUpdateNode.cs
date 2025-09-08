using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFootPinningUpdateNode : CUnaryUpdateNode, IFootPinningUpdateNode {

  public CFootPinningUpdateNode(nint handle) : base(handle) {
  }

  public IFootPinningPoseOpFixedData_t PoseOpFixedData {
    get => new FootPinningPoseOpFixedData_t(_Handle + Schema.GetOffset(0x9D0C68166EC45627));
  }
  public ref FootPinningTimingSource TimingSource {
    get => ref _Handle.AsRef<FootPinningTimingSource>(Schema.GetOffset(0x9D0C68164D5A2DD7));
  }
  public ref CUtlVector Params {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x9D0C6816640EA8F3));
  }
  public ref bool ResetChild {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9D0C681665CC88B6));
  }


}