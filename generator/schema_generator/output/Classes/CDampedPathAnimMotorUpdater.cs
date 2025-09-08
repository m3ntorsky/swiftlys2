using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDampedPathAnimMotorUpdater : CPathAnimMotorUpdaterBase, IDampedPathAnimMotorUpdater {

  public CDampedPathAnimMotorUpdater(nint handle) : base(handle) {
  }

  public ref float AnticipationTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1519DE4D43C5CA9B));
  }
  public ref float MinSpeedScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1519DE4DED3B5DEE));
  }
  public IAnimParamHandle AnticipationPosParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x1519DE4D86389829));
  }
  public IAnimParamHandle AnticipationHeadingParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x1519DE4D095DAB6D));
  }
  public ref float SpringConstant {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1519DE4DCE2260BE));
  }
  public ref float MinSpringTension {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1519DE4DEEE56032));
  }
  public ref float MaxSpringTension {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1519DE4DD4910BE4));
  }


}