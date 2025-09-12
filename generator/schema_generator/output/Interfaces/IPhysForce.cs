using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysForce : IPointEntity {

  
  public ISchemaUntypedField NameAttach { get; }
  
  public ref float Force { get; }
  
  public ref float ForceTime { get; }
  
  public ref CHandle<CBaseEntity> AttachedObject { get; }
  
  public ref bool WasRestored { get; }
  
  public IConstantForceController Integrator { get; }
}