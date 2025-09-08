using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IC_OP_PlaneCull : IParticleFunctionOperator {

  public ref int PlaneControlPoint { get; }
  
  public ref Vector PlaneDirection { get; }
  
  public ref bool LocalSpace { get; }
  
  public ref float PlaneOffset { get; }
  
}