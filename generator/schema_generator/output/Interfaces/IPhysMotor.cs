using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysMotor : ILogicalEntity {

  public ref CUtlSymbolLarge NameAttach { get; }
  
  public ref CUtlSymbolLarge NameAnchor { get; }
  
  public ref CHandle<CBaseEntity> AttachedObject { get; }
  
  public ref CHandle<CBaseEntity> AnchorObject { get; }
  
  public ref float SpinUp { get; }
  
  public ref float SpinDown { get; }
  
  public ref float MotorFriction { get; }
  
  public ref float AdditionalAcceleration { get; }
  
  public ref float AngularAcceleration { get; }
  
  public ref float TorqueScale { get; }
  
  public ref float TargetSpeed { get; }
  
  public ref float SpeedWhenSpinUpOrSpinDownStarted { get; }
  
  public IMotorController Motor { get; }
  
}