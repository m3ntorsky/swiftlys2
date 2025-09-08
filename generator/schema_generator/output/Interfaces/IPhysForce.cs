using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysForce : IPointEntity {

  public ref CUtlSymbolLarge NameAttach { get; }
  
  public ref float Force { get; }
  
  public ref float ForceTime { get; }
  
  public CHandle<IBaseEntity> AttachedObject { get; }
  
  public ref bool WasRestored { get; }
  
  public IConstantForceController Integrator { get; }
  
}