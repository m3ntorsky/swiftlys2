using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAttributeList : ISchemaClass {

  public ref CUtlVectorEmbeddedNetworkVar Attributes { get; }
  
  public IAttributeManager Manager { get; }
  
}