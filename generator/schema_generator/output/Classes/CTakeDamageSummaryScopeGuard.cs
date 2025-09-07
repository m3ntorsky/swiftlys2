using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTakeDamageSummaryScopeGuard : SchemaClass, ITakeDamageSummaryScopeGuard {

  public CTakeDamageSummaryScopeGuard(nint handle) : base(handle) {
  }

  public CTakeDamageSummaryScopeGuard(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< SummaryTakeDamageInfo_t* > Summaries {
    get => ref _Handle.AsRef<CUtlVector< SummaryTakeDamageInfo_t* >>(Schema.GetOffset(0x1CAF012DD0AD2A53));
  }


}