using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMaterialParamInt_t : IMaterialParam_t {

  public ref int Value { get; }
  
}