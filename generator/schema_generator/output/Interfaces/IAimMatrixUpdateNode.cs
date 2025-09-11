using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAimMatrixUpdateNode : IUnaryUpdateNode {

  
  public IAimMatrixOpFixedSettings_t OpFixedSettings { get; }
  
  public ref AnimVectorSource Target { get; }
  
  public IAnimParamHandle ParamIndex { get; }
  
  public IHSequence Sequence { get; }
  
  public ref bool ResetChild { get; }
  
  public ref bool LockWhenWaning { get; }
}