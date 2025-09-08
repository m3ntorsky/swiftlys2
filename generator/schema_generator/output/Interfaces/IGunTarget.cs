using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IGunTarget : IBaseToggle {

  public ref bool On { get; }
  
  public CHandle<IBaseEntity> TargetEnt { get; }
  
  public IEntityIOOutput OnDeath { get; }
  
}