using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISceneEventInfo : ISchemaClass {

  
  public ref int Layer { get; }
  
  public ref int Priority { get; }
  
  public IHSequence Sequence { get; }
  
  public ref float Weight { get; }
  
  public ref bool HasArrived { get; }
  
  public ref int Type { get; }
  
  public IGameTime_t Next { get; }
  
  public ref bool IsGesture { get; }
  
  public ref bool ShouldRemove { get; }
  
  public ref CHandle<CBaseEntity> Target { get; }
  
  public ISceneEventId_t SceneEventId { get; }
  
  public ref bool ClientSide { get; }
  
  public ref bool Started { get; }
}