using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface Isndopvarlatchdata_t : ISchemaClass {

  
  public ref CUtlSymbolLarge Stack { get; }
  
  public ref CUtlSymbolLarge Operator { get; }
  
  public ref CUtlSymbolLarge Opvar { get; }
  
  public ref float Val { get; }
  
  public ref Vector Pos { get; }
}