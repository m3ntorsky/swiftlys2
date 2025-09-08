using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMovementComponentUpdater : IAnimComponentUpdater {

  public ref CUtlVector Motors { get; }
  
  public IAnimInputDamping FacingDamping { get; }
  
  public ref int DefaultMotorIndex { get; }
  
  public ref float DefaultRunSpeed { get; }
  
  public ref bool MoveVarsDisabled { get; }
  
  public ref bool NetworkPath { get; }
  
  public ref bool NetworkFacing { get; }
  
  public IAnimParamHandle ParamHandles { get; }
  
}