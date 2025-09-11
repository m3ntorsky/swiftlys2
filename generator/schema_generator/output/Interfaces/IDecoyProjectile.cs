using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDecoyProjectile : IBaseCSGrenadeProjectile {

  
  public ref int DecoyShotTick { get; }
  
  public ref int ShotsRemaining { get; }
  
  public IGameTime_t ExpireTime { get; }
  
  public ref ushort DecoyWeaponDefIndex { get; }
}