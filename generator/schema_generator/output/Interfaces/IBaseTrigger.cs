using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseTrigger : IBaseToggle {

  public IEntityIOOutput OnStartTouch { get; }
  
  public IEntityIOOutput OnStartTouchAll { get; }
  
  public IEntityIOOutput OnEndTouch { get; }
  
  public IEntityIOOutput OnEndTouchAll { get; }
  
  public IEntityIOOutput OnTouching { get; }
  
  public IEntityIOOutput OnTouchingEachEntity { get; }
  
  public IEntityIOOutput OnNotTouching { get; }
  
  public ref CUtlVector TouchingEntities { get; }
  
  public ref CUtlSymbolLarge FilterName { get; }
  
  public CHandle<IBaseFilter> Filter { get; }
  
  public ref bool Disabled { get; }
  
  public ref bool UseAsyncQueries { get; }
  
}