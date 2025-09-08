using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Step_PublicOutput : IPulseCell_BaseFlow {

  public IPulseRuntimeOutputIndex_t OutputIndex { get; }
  
}