using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_SetControlPointOrientation : IParticleFunctionPreEmission {

  
  public ref bool UseWorldLocation { get; }
  
  public ref bool Randomize { get; }
  
  public ref bool SetOnce { get; }
  
  public ref int CP { get; }
  
  public ref int HeadLocation { get; }
  
  public ref QAngle Rotation { get; }
  
  public ref QAngle RotationB { get; }
  
  public IParticleCollectionFloatInput Interpolation { get; }
}