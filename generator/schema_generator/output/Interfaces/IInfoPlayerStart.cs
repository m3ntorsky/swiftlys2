using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IInfoPlayerStart : IPointEntity {

  public ref bool Disabled { get; }
  
  public ref bool IsMaster { get; }
  
  public ref CGlobalSymbol PawnSubclass { get; }
  
}