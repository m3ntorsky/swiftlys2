using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFlashbangProjectile : IBaseCSGrenadeProjectile {

  
  public ref float TimeToDetonate { get; }
  
  public ref byte NumOpponentsHit { get; }
  
  public ref byte NumTeammatesHit { get; }
}