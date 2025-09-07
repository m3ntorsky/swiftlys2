using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SummaryTakeDamageInfo_t : SchemaClass, ISummaryTakeDamageInfo_t {

  public SummaryTakeDamageInfo_t(nint handle) : base(handle) {
  }

  public SummaryTakeDamageInfo_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int SummarisedCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x8A8061E2B62D7D04));
  }
  public ITakeDamageInfo Info {
    get => new CTakeDamageInfo(_Handle + Schema.GetOffset(0x8A8061E20FB40705));
  }
  public ITakeDamageResult Result {
    get => new CTakeDamageResult(_Handle + Schema.GetOffset(0x8A8061E20A377624));
  }
  public ref CHandle< CBaseEntity > Target {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x8A8061E295A3933A));
  }


}