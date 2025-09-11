using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IParticleTransformInput : IParticleInput {

  
  public ref ParticleTransformType_t Type { get; }
  
  public ISchemaUntypedField NamedValue { get; }
  
  public ref bool FollowNamedValue { get; }
  
  public ref bool SupportsDisabled { get; }
  
  public ref bool UseOrientation { get; }
  
  public ref int ControlPoint { get; }
  
  public ref int ControlPointRangeMax { get; }
  
  public ref float EndCPGrowthTime { get; }
}