using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleVecInput : IParticleInput {

  public ref ParticleVecType_t Type { get; }
  
  public ref Vector LiteralValue { get; }
  
  public ref Color LiteralColor { get; }
  
  public ISchemaUntypedField NamedValue { get; }
  
  public ref bool FollowNamedValue { get; }
  
  public IParticleAttributeIndex_t VectorAttribute { get; }
  
  public ref Vector VectorAttributeScale { get; }
  
  public ref int ControlPoint { get; }
  
  public ref int DeltaControlPoint { get; }
  
  public ref Vector CPValueScale { get; }
  
  public ref Vector CPRelativePosition { get; }
  
  public ref Vector CPRelativeDir { get; }
  
  public IParticleFloatInput FloatComponentX { get; }
  
  public IParticleFloatInput FloatComponentY { get; }
  
  public IParticleFloatInput FloatComponentZ { get; }
  
  public IParticleFloatInput FloatInterp { get; }
  
  public ref float InterpInput0 { get; }
  
  public ref float InterpInput1 { get; }
  
  public ref Vector InterpOutput0 { get; }
  
  public ref Vector InterpOutput1 { get; }
  
  public ISchemaUntypedField Gradient { get; }
  
  public ref Vector RandomMin { get; }
  
  public ref Vector RandomMax { get; }
  
}