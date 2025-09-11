using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_INIT_CreatePhyllotaxis : IParticleFunctionInitializer {

  
  public ref int ControlPointNumber { get; }
  
  public ref int ScaleCP { get; }
  
  public ref int Component { get; }
  
  public ref float RadCentCore { get; }
  
  public ref float RadPerPoint { get; }
  
  public ref float RadPerPointTo { get; }
  
  public ref float FpointAngle { get; }
  
  public ref float FsizeOverall { get; }
  
  public ref float RadBias { get; }
  
  public ref float MinRad { get; }
  
  public ref float DistBias { get; }
  
  public ref bool UseLocalCoords { get; }
  
  public ref bool UseWithContEmit { get; }
  
  public ref bool UseOrigRadius { get; }
}