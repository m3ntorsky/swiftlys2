using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointPositions : IParticleFunctionPreEmission {

  
  public ref bool UseWorldLocation { get; }
  
  public ref bool Orient { get; }
  
  public ref bool SetOnce { get; }
  
  public ref int CP1 { get; }
  
  public ref int CP2 { get; }
  
  public ref int CP3 { get; }
  
  public ref int CP4 { get; }
  
  public ref Vector CP1Pos { get; }
  
  public ref Vector CP2Pos { get; }
  
  public ref Vector CP3Pos { get; }
  
  public ref Vector CP4Pos { get; }
  
  public ref int HeadLocation { get; }
}