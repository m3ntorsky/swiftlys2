using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IStopAtGoalUpdateNode : IUnaryUpdateNode {

  
  public ref float OuterRadius { get; }
  
  public ref float InnerRadius { get; }
  
  public ref float MaxScale { get; }
  
  public ref float MinScale { get; }
  
  public IAnimInputDamping Damping { get; }
}