using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysFixed : IPhysConstraint {

  
  public ref float LinearFrequency { get; }
  
  public ref float LinearDampingRatio { get; }
  
  public ref float AngularFrequency { get; }
  
  public ref float AngularDampingRatio { get; }
  
  public ref bool EnableLinearConstraint { get; }
  
  public ref bool EnableAngularConstraint { get; }
  
  public ISchemaUntypedField BoneName1 { get; }
  
  public ISchemaUntypedField BoneName2 { get; }
}