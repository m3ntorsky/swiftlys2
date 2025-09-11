using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IHitReactUpdateNode : IUnaryUpdateNode {

  
  public IHitReactFixedSettings_t OpFixedSettings { get; }
  
  public IAnimParamHandle TriggerParam { get; }
  
  public IAnimParamHandle HitBoneParam { get; }
  
  public IAnimParamHandle HitOffsetParam { get; }
  
  public IAnimParamHandle HitDirectionParam { get; }
  
  public IAnimParamHandle HitStrengthParam { get; }
  
  public ref float MinDelayBetweenHits { get; }
  
  public ref bool ResetChild { get; }
}