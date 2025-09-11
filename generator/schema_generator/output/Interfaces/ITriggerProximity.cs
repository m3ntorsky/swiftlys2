using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerProximity : IBaseTrigger {

  
  public ref CHandle<CBaseEntity> MeasureTarget { get; }
  
  public ref CUtlSymbolLarge MeasureTarget { get; }
  
  public ref float Radius { get; }
  
  public ref int Touchers { get; }
  
  public ISchemaUntypedField NearestEntityDistance { get; }
}