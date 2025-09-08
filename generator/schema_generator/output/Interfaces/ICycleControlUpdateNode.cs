using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICycleControlUpdateNode : IUnaryUpdateNode {

  public ref AnimValueSource ValueSource { get; }
  
  public IAnimParamHandle ParamIndex { get; }
  
  public ref bool LockWhenWaning { get; }
  
}