using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleSystem : IBaseModelEntity {

  public ISchemaFixedString SnapshotFileName { get; }
  
  public ref bool Active { get; }
  
  public ref bool Frozen { get; }
  
  public ref float FreezeTransitionDuration { get; }
  
  public ref int StopType { get; }
  
  public ref bool AnimateDuringGameplayPause { get; }
  
  public CStrongHandle<IInfoForResourceTypeIParticleSystemDefinition> EffectIndex { get; }
  
  public IGameTime_t StartTime { get; }
  
  public ref float PreSimTime { get; }
  
  public ISchemaFixedArray<Vector> ServerControlPoints { get; }
  
  public ISchemaFixedArray<byte> ServerControlPointAssignments { get; }
  
  public CHandle<IBaseEntity> ControlPointEnts { get; }
  
  public ref bool NoSave { get; }
  
  public ref bool NoFreeze { get; }
  
  public ref bool NoRamp { get; }
  
  public ref bool StartActive { get; }
  
  public ref CUtlSymbolLarge EffectName { get; }
  
  public ISchemaFixedArray<CUtlSymbolLarge> ControlPointNames { get; }
  
  public ref int DataCP { get; }
  
  public ref Vector DataCPValue { get; }
  
  public ref int TintCP { get; }
  
  public ref Color Tint { get; }
  
}