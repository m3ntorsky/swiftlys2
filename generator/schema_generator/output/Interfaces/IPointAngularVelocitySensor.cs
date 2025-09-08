using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointAngularVelocitySensor : IPointEntity {

  public CHandle<IBaseEntity> TargetEntity { get; }
  
  public ref float Threshold { get; }
  
  public ref int LastCompareResult { get; }
  
  public ref int LastFireResult { get; }
  
  public IGameTime_t FireTime { get; }
  
  public ref float FireInterval { get; }
  
  public ref float LastAngVelocity { get; }
  
  public ref QAngle LastOrientation { get; }
  
  public ref Vector Axis { get; }
  
  public ref bool UseHelper { get; }
  
  public ISchemaUntypedField AngularVelocity { get; }
  
  public IEntityIOOutput OnLessThan { get; }
  
  public IEntityIOOutput OnLessThanOrEqualTo { get; }
  
  public IEntityIOOutput OnGreaterThan { get; }
  
  public IEntityIOOutput OnGreaterThanOrEqualTo { get; }
  
  public IEntityIOOutput OnEqualTo { get; }
  
}