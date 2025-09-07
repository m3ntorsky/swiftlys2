using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlayerInputAnimMotorUpdater : CAnimMotorUpdaterBase, IPlayerInputAnimMotorUpdater {

  public CPlayerInputAnimMotorUpdater(nint handle) : base(handle) {
  }

  public CPlayerInputAnimMotorUpdater(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< float32 > SampleTimes {
    get => ref _Handle.AsRef<CUtlVector< float32 >>(Schema.GetOffset(0xA117CC02471975DF));
  }
  public ref float SpringConstant {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA117CC02CE2260BE));
  }
  public ref float AnticipationDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA117CC0264273401));
  }
  public IAnimParamHandle AnticipationPosParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xA117CC0286389829));
  }
  public IAnimParamHandle AnticipationHeadingParam {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xA117CC02095DAB6D));
  }
  public ref bool UseAcceleration {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA117CC02254F8B08));
  }


}