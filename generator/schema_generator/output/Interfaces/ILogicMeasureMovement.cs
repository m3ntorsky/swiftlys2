using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicMeasureMovement : ILogicalEntity {

  
  public ref CUtlSymbolLarge StrMeasureTarget { get; }
  
  public ref CUtlSymbolLarge StrMeasureReference { get; }
  
  public ref CUtlSymbolLarge StrTargetReference { get; }
  
  public ref CHandle<CBaseEntity> MeasureTarget { get; }
  
  public ref CHandle<CBaseEntity> MeasureReference { get; }
  
  public ref CHandle<CBaseEntity> Target { get; }
  
  public ref CHandle<CBaseEntity> TargetReference { get; }
  
  public ref float Scale { get; }
  
  public ref int MeasureType { get; }
}