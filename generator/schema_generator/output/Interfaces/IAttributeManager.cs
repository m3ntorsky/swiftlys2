using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAttributeManager : ISchemaClass {

  public ref CUtlVector Providers { get; }
  
  public ref int ReapplyProvisionParity { get; }
  
  public CHandle<IBaseEntity> Outer { get; }
  
  public ref bool PreventLoopback { get; }
  
  public ref attributeprovidertypes_t ProviderType { get; }
  
  public ref CUtlVector CachedResults { get; }
  
}