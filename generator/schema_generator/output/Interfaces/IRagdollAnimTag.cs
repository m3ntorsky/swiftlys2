using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRagdollAnimTag : IAnimTagBase {

  public ref CGlobalSymbol ProfileName { get; }
  
}