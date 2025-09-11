using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPointVelocitySensor : IPointEntity {

  
  public ref CHandle<CBaseEntity> TargetEntity { get; }
  
  public ref Vector Axis { get; }
  
  public ref bool Enabled { get; }
  
  public ref float PrevVelocity { get; }
  
  public ref float AvgInterval { get; }
  
  public ISchemaUntypedField Velocity { get; }
}