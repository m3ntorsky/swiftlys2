using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerFan : IBaseTrigger {

  
  public ref Vector FanOrigin { get; }
  
  public ref Vector FanOriginOffset { get; }
  
  public ref Vector FanEnd { get; }
  
  public ref Vector NoiseDirectionTarget { get; }
  
  public ref Vector Direction { get; }
  
  public ref bool PushTowardsInfoTarget { get; }
  
  public ref bool PushAwayFromInfoTarget { get; }
  
  public ref Quaternion NoiseDelta { get; }
  
  public ref CHandle<CInfoFan> InfoFan { get; }
  
  public ref float Force { get; }
  
  public ref bool Falloff { get; }
  
  public ICountdownTimer RampTimer { get; }
  
  public ref CUtlSymbolLarge InfoFan { get; }
  
  public ref float RopeForceScale { get; }
  
  public ref float ParticleForceScale { get; }
  
  public ref float PlayerForce { get; }
  
  public ref bool PlayerWindblock { get; }
  
  public ref float NPCForce { get; }
  
  public ref float RampTime { get; }
  
  public ref float NoiseDegrees { get; }
  
  public ref float NoiseSpeed { get; }
  
  public ref bool PushPlayer { get; }
  
  public ref bool RampDown { get; }
  
  public ref int ManagerFanIdx { get; }
}