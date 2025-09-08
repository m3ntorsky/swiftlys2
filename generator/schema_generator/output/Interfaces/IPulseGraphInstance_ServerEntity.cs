using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseGraphInstance_ServerEntity : IBasePulseGraphInstance {

  public ref CHandle<CBaseEntity> Owner { get; }
  
  public ref bool Activated { get; }
  
  public ref CUtlSymbolLarge NameFixupStaticPrefix { get; }
  
  public ref CUtlSymbolLarge NameFixupParent { get; }
  
  public ref CUtlSymbolLarge NameFixupLocal { get; }
  
  public ref CUtlSymbolLarge ProceduralWorldNameForRelays { get; }
  
}