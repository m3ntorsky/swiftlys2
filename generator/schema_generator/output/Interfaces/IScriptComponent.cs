using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IScriptComponent : IEntityComponent {

  public ref CUtlSymbolLarge ScriptClassName { get; }
  
}