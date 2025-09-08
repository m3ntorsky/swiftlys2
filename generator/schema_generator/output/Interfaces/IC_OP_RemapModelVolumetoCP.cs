using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RemapModelVolumetoCP : IParticleFunctionPreEmission {

  public ref BBoxVolumeType_t BBoxType { get; }
  
  public ref int InControlPointNumber { get; }
  
  public ref int OutControlPointNumber { get; }
  
  public ref int OutControlPointMaxNumber { get; }
  
  public ref int Field { get; }
  
  public ref float InputMin { get; }
  
  public ref float InputMax { get; }
  
  public ref float OutputMin { get; }
  
  public ref float OutputMax { get; }
  
  public ref bool BBoxOnly { get; }
  
  public ref bool CubeRoot { get; }
  
}