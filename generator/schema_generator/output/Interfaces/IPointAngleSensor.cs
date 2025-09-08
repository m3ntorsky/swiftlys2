using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointAngleSensor : IPointEntity {

  public ref bool Disabled { get; }
  
  public ref CUtlSymbolLarge LookAtName { get; }
  
  public CHandle<IBaseEntity> TargetEntity { get; }
  
  public CHandle<IBaseEntity> LookAtEntity { get; }
  
  public ref float Duration { get; }
  
  public ref float DotTolerance { get; }
  
  public IGameTime_t FacingTime { get; }
  
  public ref bool Fired { get; }
  
  public IEntityIOOutput OnFacingLookat { get; }
  
  public IEntityIOOutput OnNotFacingLookat { get; }
  
  public ISchemaUntypedField TargetDir { get; }
  
  public ISchemaUntypedField FacingPercentage { get; }
  
}