using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPGDInstruction_t : ISchemaClass {

  
  public ref PulseInstructionCode_t Code { get; }
  
  public IPulseRuntimeVarIndex_t Var { get; }
  
  public IPulseRuntimeRegisterIndex_t Reg0 { get; }
  
  public IPulseRuntimeRegisterIndex_t Reg1 { get; }
  
  public IPulseRuntimeRegisterIndex_t Reg2 { get; }
  
  public IPulseRuntimeInvokeIndex_t InvokeBindingIndex { get; }
  
  public IPulseRuntimeChunkIndex_t Chunk { get; }
  
  public ref int DestInstruction { get; }
  
  public IPulseRuntimeCallInfoIndex_t CallInfoIndex { get; }
  
  public IPulseRuntimeConstantIndex_t ConstIdx { get; }
  
  public IPulseRuntimeDomainValueIndex_t DomainValueIdx { get; }
  
  public IPulseRuntimeBlackboardReferenceIndex_t BlackboardReferenceIdx { get; }
}