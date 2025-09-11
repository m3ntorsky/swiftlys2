using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IHostageExpresserShim : IBaseCombatCharacter {

  
  public IAI_Expresser Expresser { get; }
}