using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapCPtoCP : IParticleFunctionPreEmission {

  
  public ref int InputControlPoint { get; }
  
  public ref int OutputControlPoint { get; }
  
  public ref int InputField { get; }
  
  public ref int OutputField { get; }
  
  public ref float InputMin { get; }
  
  public ref float InputMax { get; }
  
  public ref float OutputMin { get; }
  
  public ref float OutputMax { get; }
  
  public ref bool Derivative { get; }
  
  public ref float InterpRate { get; }
}