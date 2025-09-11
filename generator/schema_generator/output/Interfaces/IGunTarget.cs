using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IGunTarget : IBaseToggle {

  
  public ref bool On { get; }
  
  public ref CHandle<CBaseEntity> TargetEnt { get; }
  
  public IEntityIOOutput OnDeath { get; }
}