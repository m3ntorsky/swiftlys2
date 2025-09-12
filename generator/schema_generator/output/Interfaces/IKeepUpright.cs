using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IKeepUpright : IPointEntity {

  
  public ref Vector WorldGoalAxis { get; }
  
  public ref Vector LocalTestAxis { get; }
  
  public ISchemaUntypedField NameAttach { get; }
  
  public ref CHandle<CBaseEntity> AttachedObject { get; }
  
  public ref float AngularLimit { get; }
  
  public ref bool Active { get; }
  
  public ref bool DampAllRotation { get; }
}