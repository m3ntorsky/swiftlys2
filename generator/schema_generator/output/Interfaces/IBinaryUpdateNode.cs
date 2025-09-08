using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBinaryUpdateNode : IAnimUpdateNodeBase {

  public IAnimUpdateNodeRef Child1 { get; }
  
  public IAnimUpdateNodeRef Child2 { get; }
  
  public ref BinaryNodeTiming TimingBehavior { get; }
  
  public ref float TimingBlend { get; }
  
  public ref bool ResetChild1 { get; }
  
  public ref bool ResetChild2 { get; }
  
}