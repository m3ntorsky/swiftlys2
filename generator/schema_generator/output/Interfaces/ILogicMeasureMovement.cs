using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicMeasureMovement : ILogicalEntity {

  
  public ISchemaUntypedField StrMeasureTarget { get; }
  
  public ISchemaUntypedField StrMeasureReference { get; }
  
  public ISchemaUntypedField StrTargetReference { get; }
  
  public ref CHandle<CBaseEntity> MeasureTarget { get; }
  
  public ref CHandle<CBaseEntity> MeasureReference { get; }
  
  public ref CHandle<CBaseEntity> Target { get; }
  
  public ref CHandle<CBaseEntity> TargetReference { get; }
  
  public ref float Scale { get; }
  
  public ref int MeasureType { get; }
}