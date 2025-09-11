using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IStanceOverrideUpdateNode : IUnaryUpdateNode {

  
// CUtlVector< StanceInfo_t >
  public ref CUtlVector FootStanceInfo { get; }
  
  public IAnimUpdateNodeRef StanceSourceNode { get; }
  
  public IAnimParamHandle Parameter { get; }
  
  public ref StanceOverrideMode Mode { get; }
}