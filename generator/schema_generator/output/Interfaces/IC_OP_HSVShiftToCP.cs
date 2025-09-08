using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_HSVShiftToCP : IParticleFunctionPreEmission {

  public ref int ColorCP { get; }
  
  public ref int ColorGemEnableCP { get; }
  
  public ref int OutputCP { get; }
  
  public ref Color DefaultHSVColor { get; }
  
}