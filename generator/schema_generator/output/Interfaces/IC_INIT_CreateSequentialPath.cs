using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_CreateSequentialPath : IParticleFunctionInitializer {

  
  public ref float MaxDistance { get; }
  
  public ref float NumToAssign { get; }
  
  public ref bool Loop { get; }
  
  public ref bool CPPairs { get; }
  
  public ref bool SaveOffset { get; }
  
  public IPathParameters PathParams { get; }
}