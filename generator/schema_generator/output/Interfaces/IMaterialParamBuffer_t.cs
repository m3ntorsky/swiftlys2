using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMaterialParamBuffer_t : IMaterialParam_t {

  public ref CUtlBinaryBlock Value { get; }
  
}