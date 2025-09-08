using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointToHand : IParticleFunctionPreEmission {

  public ref int CP1 { get; }
  
  public ref int Hand { get; }
  
  public ref Vector CP1Pos { get; }
  
  public ref bool OrientToHand { get; }
  
}