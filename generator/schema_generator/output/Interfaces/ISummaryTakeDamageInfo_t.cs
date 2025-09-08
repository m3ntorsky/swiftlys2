using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISummaryTakeDamageInfo_t : ISchemaClass {

  public ref int SummarisedCount { get; }
  
  public ITakeDamageInfo Info { get; }
  
  public ITakeDamageResult Result { get; }
  
  public ref CHandle<CBaseEntity> Target { get; }
  
}