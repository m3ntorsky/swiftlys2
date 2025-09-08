using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITwoBoneIKUpdateNode : IUnaryUpdateNode {

  public ITwoBoneIKSettings_t OpFixedData { get; }
  
}