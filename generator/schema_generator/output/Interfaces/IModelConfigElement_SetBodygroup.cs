using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IModelConfigElement_SetBodygroup : IModelConfigElement {

  
  public ref CGlobalSymbol GroupName { get; }
  
  public ref int Choice { get; }
}