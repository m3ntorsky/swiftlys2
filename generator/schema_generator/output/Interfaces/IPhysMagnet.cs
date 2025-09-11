using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysMagnet : IBaseAnimGraph {

  
  public IEntityIOOutput OnMagnetAttach { get; }
  
  public IEntityIOOutput OnMagnetDetach { get; }
  
  public ref float MassScale { get; }
  
  public ref float ForceLimit { get; }
  
  public ref float TorqueLimit { get; }
  
// CUtlVector< magnetted_objects_t >
  public ref CUtlVector MagnettedEntities { get; }
  
  public ref bool Active { get; }
  
  public ref bool HasHitSomething { get; }
  
  public ref float TotalMass { get; }
  
  public ref float Radius { get; }
  
  public IGameTime_t NextSuckTime { get; }
  
  public ref int MaxObjectsAttached { get; }
}