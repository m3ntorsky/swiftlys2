using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_PositionOffsetToCP : IParticleFunctionInitializer {

  
  public ref int ControlPointNumberStart { get; }
  
  public ref int ControlPointNumberEnd { get; }
  
  public ref bool LocalCoords { get; }
}