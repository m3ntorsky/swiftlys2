using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILookAtUpdateNode : IUnaryUpdateNode {

  public ILookAtOpFixedSettings_t OpFixedSettings { get; }
  
  public ref AnimVectorSource Target { get; }
  
  public IAnimParamHandle ParamIndex { get; }
  
  public IAnimParamHandle WeightParamIndex { get; }
  
  public ref bool ResetChild { get; }
  
  public ref bool LockWhenWaning { get; }
  
}