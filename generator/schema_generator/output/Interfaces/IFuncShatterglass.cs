using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncShatterglass : IBaseModelEntity {

  
  public ref matrix3x4_t MatPanelTransform { get; }
  
  public ref matrix3x4_t MatPanelTransformWsTemp { get; }
  
  public ref CUtlVector<uint> ShatterGlassShards { get; }
  
  public ref Vector2D PanelSize { get; }
  
  public IGameTime_t LastShatterSoundEmitTime { get; }
  
  public IGameTime_t LastCleanupTime { get; }
  
  public IGameTime_t InitAtTime { get; }
  
  public ref float GlassThickness { get; }
  
  public ref float SpawnInvulnerability { get; }
  
  public ref bool BreakSilent { get; }
  
  public ref bool BreakShardless { get; }
  
  public ref bool Broken { get; }
  
  public ref bool GlassNavIgnore { get; }
  
  public ref bool GlassInFrame { get; }
  
  public ref bool StartBroken { get; }
  
  public ref byte InitialDamageType { get; }
  
  public ref CUtlSymbolLarge DamagePositioningEntityName01 { get; }
  
  public ref CUtlSymbolLarge DamagePositioningEntityName02 { get; }
  
  public ref CUtlSymbolLarge DamagePositioningEntityName03 { get; }
  
  public ref CUtlSymbolLarge DamagePositioningEntityName04 { get; }
  
  public ref CUtlVector<Vector> InitialDamagePositions { get; }
  
  public ref CUtlVector<Vector> ExtraDamagePositions { get; }
  
  public ref CUtlVector<Vector4D> InitialPanelVertices { get; }
  
  public IEntityIOOutput OnBroken { get; }
  
  public ref byte SurfaceType { get; }
  
  public ref CStrongHandle<InfoForResourceTypeIMaterial2> MaterialDamageBase { get; }
}