using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysExplosion : IPointEntity {

  
  public ref bool ExplodeOnSpawn { get; }
  
  public ref float Magnitude { get; }
  
  public ref float Damage { get; }
  
  public ref float Radius { get; }
  
  public ref CUtlSymbolLarge TargetEntityName { get; }
  
  public ref float InnerRadius { get; }
  
  public ref float PushScale { get; }
  
  public ref bool ConvertToDebrisWhenPossible { get; }
  
  public ref bool AffectInvulnerableEnts { get; }
  
  public IEntityIOOutput OnPushedPlayer { get; }
}