using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISlowDownOnSlopesUpdateNode : IUnaryUpdateNode {

  
  public ref float SlowDownStrength { get; }
}