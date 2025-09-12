using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IInstructorEventEntity : IPointEntity {

  
  public ISchemaUntypedField Name { get; }
  
  public ISchemaUntypedField HintTargetEntity { get; }
  
  public ref CHandle<CBasePlayerPawn> TargetPlayer { get; }
}