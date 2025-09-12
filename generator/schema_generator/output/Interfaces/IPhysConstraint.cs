using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysConstraint : ILogicalEntity {

  
  public ISchemaUntypedField NameAttach1 { get; }
  
  public ISchemaUntypedField NameAttach2 { get; }
  
  public ref CHandle<CBaseEntity> Attach1 { get; }
  
  public ref CHandle<CBaseEntity> Attach2 { get; }
  
  public ISchemaUntypedField NameAttachment1 { get; }
  
  public ISchemaUntypedField NameAttachment2 { get; }
  
  public ISchemaUntypedField BreakSound { get; }
  
  public ref float ForceLimit { get; }
  
  public ref float TorqueLimit { get; }
  
  public ref float MinTeleportDistance { get; }
  
  public ref bool SnapObjectPositions { get; }
  
  public IEntityIOOutput OnBreak { get; }
}