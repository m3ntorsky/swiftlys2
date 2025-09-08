using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMolotovProjectile : IBaseCSGrenadeProjectile {

  public ref bool IsIncGrenade { get; }
  
  public ref bool Detonated { get; }
  
  public IIntervalTimer StillTimer { get; }
  
  public ref bool HasBouncedOffPlayer { get; }
  
}