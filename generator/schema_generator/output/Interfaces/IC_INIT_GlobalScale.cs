using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_GlobalScale : IParticleFunctionInitializer {

  public ref float Scale { get; }
  
  public ref int ScaleControlPointNumber { get; }
  
  public ref int ControlPointNumber { get; }
  
  public ref bool ScaleRadius { get; }
  
  public ref bool ScalePosition { get; }
  
  public ref bool ScaleVelocity { get; }
  
}