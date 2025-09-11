using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapSpeedtoCP : IParticleFunctionPreEmission {

  
  public ref int InControlPointNumber { get; }
  
  public ref int OutControlPointNumber { get; }
  
  public ref int Field { get; }
  
  public ref float InputMin { get; }
  
  public ref float InputMax { get; }
  
  public ref float OutputMin { get; }
  
  public ref float OutputMax { get; }
  
  public ref bool UseDeltaV { get; }
}