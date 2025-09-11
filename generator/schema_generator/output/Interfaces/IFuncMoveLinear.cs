using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncMoveLinear : IBaseToggle {

  
  public ref MoveLinearAuthoredPos_t AuthoredPosition { get; }
  
  public ref QAngle MoveEntitySpace { get; }
  
  public ref Vector MoveDirParentSpace { get; }
  
  public ref CUtlSymbolLarge SoundStart { get; }
  
  public ref CUtlSymbolLarge SoundStop { get; }
  
  public ref CUtlSymbolLarge CurrentSound { get; }
  
  public ref float BlockDamage { get; }
  
  public ref float StartPosition { get; }
  
  public IEntityIOOutput OnFullyOpen { get; }
  
  public IEntityIOOutput OnFullyClosed { get; }
  
  public ref bool CreateMovableNavMesh { get; }
  
  public ref bool AllowMovableNavMeshDockingOnEntireEntity { get; }
  
  public ref bool CreateNavObstacle { get; }
}