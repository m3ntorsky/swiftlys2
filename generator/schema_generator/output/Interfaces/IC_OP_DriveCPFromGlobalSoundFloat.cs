using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_DriveCPFromGlobalSoundFloat : IParticleFunctionPreEmission {

  public ref int OutputControlPoint { get; }
  
  public ref int OutputField { get; }
  
  public ref float InputMin { get; }
  
  public ref float InputMax { get; }
  
  public ref float OutputMin { get; }
  
  public ref float OutputMax { get; }
  
  public ref CUtlString StackName { get; }
  
  public ref CUtlString OperatorName { get; }
  
  public ref CUtlString FieldName { get; }
  
}