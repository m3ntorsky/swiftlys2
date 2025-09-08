using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IActiveModelConfig_t : ISchemaClass {

  public IModelConfigHandle_t Handle { get; }
  
  public ref CUtlSymbolLarge Name { get; }
  
  public ref CUtlVector<CHandle<CBaseModelEntity>> AssociatedEntities { get; }
  
  public ref CUtlVector<CUtlSymbolLarge> AssociatedEntityNames { get; }
  
}