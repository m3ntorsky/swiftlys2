using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicNavigation : ILogicalEntity {

  public ref bool IsOn { get; }
  
  public ref navproperties_t NavProperty { get; }
  
}