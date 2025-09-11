using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDynamicProp : IBreakableProp {

  
  public ref bool CreateNavObstacle { get; }
  
  public ref bool NavObstacleUpdatesOverridden { get; }
  
  public ref bool UseHitboxesForRenderBox { get; }
  
  public ref bool UseAnimGraph { get; }
  
  public IEntityIOOutput OutputAnimBegun { get; }
  
  public IEntityIOOutput OutputAnimOver { get; }
  
  public IEntityIOOutput OutputAnimLoopCycleOver { get; }
  
  public IEntityIOOutput OnAnimReachedStart { get; }
  
  public IEntityIOOutput OnAnimReachedEnd { get; }
  
  public ref CUtlSymbolLarge IdleAnim { get; }
  
  public ref AnimLoopMode_t IdleAnimLoopMode { get; }
  
  public ref bool RandomizeCycle { get; }
  
  public ref bool StartDisabled { get; }
  
  public ref bool FiredStartEndOutput { get; }
  
  public ref bool ForceNpcExclude { get; }
  
  public ref bool CreateNonSolid { get; }
  
  public ref bool IsOverrideProp { get; }
  
  public ref int InitialGlowState { get; }
  
  public ref int GlowRange { get; }
  
  public ref int GlowRangeMin { get; }
  
  public ref Color GlowColor { get; }
  
  public ref int GlowTeam { get; }
}