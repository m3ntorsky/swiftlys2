using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITakeDamageSummaryScopeGuard : ISchemaClass {

  public ref CUtlVector<PointerTo<SummaryTakeDamageInfo_t>> Summaries { get; }
  
}