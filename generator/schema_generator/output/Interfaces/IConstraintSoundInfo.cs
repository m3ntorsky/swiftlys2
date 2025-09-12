using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IConstraintSoundInfo : ISchemaClass {

  
  public IVelocitySampler Sampler { get; }
  
  public ISimpleConstraintSoundProfile SoundProfile { get; }
  
  public ref Vector ForwardAxis { get; }
  
  public ISchemaUntypedField TravelSoundFwd { get; }
  
  public ISchemaUntypedField TravelSoundBack { get; }
  
  public ISchemaUntypedField ReversalSounds { get; }
  
  public ref bool PlayTravelSound { get; }
  
  public ref bool PlayReversalSound { get; }
}