using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysBox : IBreakable {

  public ref int DamageType { get; }
  
  public ref int DamageToEnableMotion { get; }
  
  public ref float ForceToEnableMotion { get; }
  
  public ref Vector HoverPosePosition { get; }
  
  public ref QAngle HoverPoseAngles { get; }
  
  public ref bool NotSolidToWorld { get; }
  
  public ref bool EnableUseOutput { get; }
  
  public ref HoverPoseFlags_t HoverPoseFlags { get; }
  
  public ref float TouchOutputPerEntityDelay { get; }
  
  public IEntityIOOutput OnDamaged { get; }
  
  public IEntityIOOutput OnAwakened { get; }
  
  public IEntityIOOutput OnMotionEnabled { get; }
  
  public IEntityIOOutput OnPlayerUse { get; }
  
  public IEntityIOOutput OnStartTouch { get; }
  
  public CHandle<IBasePlayerPawn> CarryingPlayer { get; }
  
}