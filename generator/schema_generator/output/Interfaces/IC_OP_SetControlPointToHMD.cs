using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointToHMD : IParticleFunctionPreEmission {

  public ref int CP1 { get; }
  
  public ref Vector CP1Pos { get; }
  
  public ref bool OrientToHMD { get; }
  
}