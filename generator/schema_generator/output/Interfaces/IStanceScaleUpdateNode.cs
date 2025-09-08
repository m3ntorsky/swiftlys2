using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IStanceScaleUpdateNode : IUnaryUpdateNode {

  public IAnimParamHandle Param { get; }
  
}