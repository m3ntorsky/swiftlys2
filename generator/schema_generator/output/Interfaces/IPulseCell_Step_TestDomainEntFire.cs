using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPulseCell_Step_TestDomainEntFire : IPulseCell_BaseFlow {

  public ref CUtlString Input { get; }
  
}