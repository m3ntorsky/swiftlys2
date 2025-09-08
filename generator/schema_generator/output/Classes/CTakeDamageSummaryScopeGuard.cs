using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTakeDamageSummaryScopeGuard : SchemaClass, ITakeDamageSummaryScopeGuard {

  public CTakeDamageSummaryScopeGuard(nint handle) : base(handle) {
  }

  public ref CUtlVector<PointerTo<SummaryTakeDamageInfo_t>> Summaries {
    get => ref _Handle.AsRef<CUtlVector<PointerTo<SummaryTakeDamageInfo_t>>>(Schema.GetOffset(0x1CAF012DD0AD2A53));
  }


}