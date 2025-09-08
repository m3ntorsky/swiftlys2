using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_ControlPointToRadialScreenSpace : IParticleFunctionPreEmission {

  public ref int CPIn { get; }
  
  public ref Vector CP1Pos { get; }
  
  public ref int CPOut { get; }
  
  public ref int CPOutField { get; }
  
  public ref int CPSSPosOut { get; }
  
}