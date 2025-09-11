using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISymbolAnimParameter : IConcreteAnimParameter {

  
  public ref CGlobalSymbol DefaultValue { get; }
}