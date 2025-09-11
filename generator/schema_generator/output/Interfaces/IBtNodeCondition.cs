using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBtNodeCondition : IBtNodeDecorator {

  
  public ref bool Negated { get; }
}