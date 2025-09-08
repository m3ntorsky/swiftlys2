using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicMeasureMovement : ILogicalEntity {

  public ref CUtlSymbolLarge StrMeasureTarget { get; }
  
  public ref CUtlSymbolLarge StrMeasureReference { get; }
  
  public ref CUtlSymbolLarge StrTargetReference { get; }
  
  public CHandle<IBaseEntity> MeasureTarget { get; }
  
  public CHandle<IBaseEntity> MeasureReference { get; }
  
  public CHandle<IBaseEntity> Target { get; }
  
  public CHandle<IBaseEntity> TargetReference { get; }
  
  public ref float Scale { get; }
  
  public ref int MeasureType { get; }
  
}