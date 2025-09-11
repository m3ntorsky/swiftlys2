using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAttributeContainer : IAttributeManager {

  
  public IEconItemView Item { get; }
}