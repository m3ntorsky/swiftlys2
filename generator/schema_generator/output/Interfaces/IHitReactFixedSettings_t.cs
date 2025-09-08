using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IHitReactFixedSettings_t : ISchemaClass {

  public ref int WeightListIndex { get; }
  
  public ref int EffectedBoneCount { get; }
  
  public ref float MaxImpactForce { get; }
  
  public ref float MinImpactForce { get; }
  
  public ref float WhipImpactScale { get; }
  
  public ref float CounterRotationScale { get; }
  
  public ref float DistanceFadeScale { get; }
  
  public ref float PropagationScale { get; }
  
  public ref float WhipDelay { get; }
  
  public ref float SpringStrength { get; }
  
  public ref float WhipSpringStrength { get; }
  
  public ref float MaxAngleRadians { get; }
  
  public ref int HipBoneIndex { get; }
  
  public ref float HipBoneTranslationScale { get; }
  
  public ref float HipDipSpringStrength { get; }
  
  public ref float HipDipImpactScale { get; }
  
  public ref float HipDipDelay { get; }
  
}