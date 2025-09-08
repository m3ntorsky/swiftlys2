using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_NormalOffset : IParticleFunctionInitializer {

  public ref Vector OffsetMin { get; }
  
  public ref Vector OffsetMax { get; }
  
  public ref int ControlPointNumber { get; }
  
  public ref bool LocalCoords { get; }
  
  public ref bool Normalize { get; }
  
}