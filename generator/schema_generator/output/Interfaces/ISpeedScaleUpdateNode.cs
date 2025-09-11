using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISpeedScaleUpdateNode : IUnaryUpdateNode {

  
  public IAnimParamHandle ParamIndex { get; }
}