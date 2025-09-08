using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IInButtonState : ISchemaClass {

  public ISchemaFixedArray<ulong> ButtonStates { get; }
  
}