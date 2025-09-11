using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_RestartAfterDuration : IParticleFunctionOperator {

  
  public ref float DurationMin { get; }
  
  public ref float DurationMax { get; }
  
  public ref int CP { get; }
  
  public ref int CPField { get; }
  
  public ref int ChildGroupID { get; }
  
  public ref bool OnlyChildren { get; }
}