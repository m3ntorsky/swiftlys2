using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IJumpHelperUpdateNode : ISequenceUpdateNode {

  
  public IAnimParamHandle TargetParam { get; }
  
  public ref Vector OriginalJumpMovement { get; }
  
  public ref float OriginalJumpDuration { get; }
  
  public ref float JumpStartCycle { get; }
  
  public ref float JumpEndCycle { get; }
  
  public ref JumpCorrectionMethod CorrectionMethod { get; }
  
  public ISchemaFixedArray<bool> TranslationAxis { get; }
  
  public ref bool ScaleSpeed { get; }
}