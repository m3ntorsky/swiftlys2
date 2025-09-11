using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncRotating : IBaseModelEntity {

  
  public IEntityIOOutput OnStopped { get; }
  
  public IEntityIOOutput OnStarted { get; }
  
  public IEntityIOOutput OnReachedStart { get; }
  
  public ISchemaUntypedField LocalRotationVector { get; }
  
  public ref float FanFriction { get; }
  
  public ref float Attenuation { get; }
  
  public ref float Volume { get; }
  
  public ref float TargetSpeed { get; }
  
  public ref float MaxSpeed { get; }
  
  public ref float BlockDamage { get; }
  
  public ref CUtlSymbolLarge NoiseRunning { get; }
  
  public ref bool Reversed { get; }
  
  public ref bool AccelDecel { get; }
  
  public ref QAngle PrevLocalAngles { get; }
  
  public ref QAngle Start { get; }
  
  public ref bool StopAtStartPos { get; }
  
  public ref Vector ClientOrigin { get; }
  
  public ref QAngle ClientAngles { get; }
}