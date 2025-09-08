using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleFunction : ISchemaClass {

  public IParticleCollectionFloatInput OpStrength { get; }
  
  public ref ParticleEndcapMode_t OpEndCapState { get; }
  
  public ref float OpStartFadeInTime { get; }
  
  public ref float OpEndFadeInTime { get; }
  
  public ref float OpStartFadeOutTime { get; }
  
  public ref float OpEndFadeOutTime { get; }
  
  public ref float OpFadeOscillatePeriod { get; }
  
  public ref bool NormalizeToStopTime { get; }
  
  public ref float OpTimeOffsetMin { get; }
  
  public ref float OpTimeOffsetMax { get; }
  
  public ref int OpTimeOffsetSeed { get; }
  
  public ref int OpTimeScaleSeed { get; }
  
  public ref float OpTimeScaleMin { get; }
  
  public ref float OpTimeScaleMax { get; }
  
  public ref bool DisableOperator { get; }
  
  public ref CUtlString Notes { get; }
  
}