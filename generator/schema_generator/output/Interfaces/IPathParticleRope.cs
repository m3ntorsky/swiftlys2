using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPathParticleRope : IBaseEntity {

  
  public ref bool StartActive { get; }
  
  public ref float MaxSimulationTime { get; }
  
  public ref CUtlSymbolLarge EffectName { get; }
  
  public ref CUtlVector<CUtlSymbolLarge> PathNodes_Name { get; }
  
  public ref float ParticleSpacing { get; }
  
  public ref float Slack { get; }
  
  public ref float Radius { get; }
  
  public ref Color ColorTint { get; }
  
  public ref int EffectState { get; }
  
  public ref CStrongHandle<InfoForResourceTypeIParticleSystemDefinition> EffectIndex { get; }
  
  public ref CUtlVector<Vector> PathNodes_Position { get; }
  
  public ref CUtlVector<Vector> PathNodes_TangentIn { get; }
  
  public ref CUtlVector<Vector> PathNodes_TangentOut { get; }
  
  public ref CUtlVector<Vector> PathNodes_Color { get; }
  
  public ref CUtlVector<bool> PathNodes_PinEnabled { get; }
  
  public ref CUtlVector<float> PathNodes_RadiusScale { get; }
}