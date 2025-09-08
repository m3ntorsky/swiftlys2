using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PGDInstruction_t : SchemaClass, IPGDInstruction_t {

  public PGDInstruction_t(nint handle) : base(handle) {
  }

  public ref PulseInstructionCode_t Code {
    get => ref _Handle.AsRef<PulseInstructionCode_t>(Schema.GetOffset(0xE64AC70782D034B8));
  }
  public IPulseRuntimeVarIndex_t Var {
    get => new PulseRuntimeVarIndex_t(_Handle + Schema.GetOffset(0xE64AC707FD79AE3A));
  }
  public IPulseRuntimeRegisterIndex_t Reg0 {
    get => new PulseRuntimeRegisterIndex_t(_Handle + Schema.GetOffset(0xE64AC707203A137B));
  }
  public IPulseRuntimeRegisterIndex_t Reg1 {
    get => new PulseRuntimeRegisterIndex_t(_Handle + Schema.GetOffset(0xE64AC7071F3A11E8));
  }
  public IPulseRuntimeRegisterIndex_t Reg2 {
    get => new PulseRuntimeRegisterIndex_t(_Handle + Schema.GetOffset(0xE64AC707223A16A1));
  }
  public IPulseRuntimeInvokeIndex_t InvokeBindingIndex {
    get => new PulseRuntimeInvokeIndex_t(_Handle + Schema.GetOffset(0xE64AC707758774C2));
  }
  public IPulseRuntimeChunkIndex_t Chunk {
    get => new PulseRuntimeChunkIndex_t(_Handle + Schema.GetOffset(0xE64AC7071B1DB366));
  }
  public ref int DestInstruction {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE64AC7071C9BCE7B));
  }
  public IPulseRuntimeCallInfoIndex_t CallInfoIndex {
    get => new PulseRuntimeCallInfoIndex_t(_Handle + Schema.GetOffset(0xE64AC7075A5CA29B));
  }
  public IPulseRuntimeConstantIndex_t ConstIdx {
    get => new PulseRuntimeConstantIndex_t(_Handle + Schema.GetOffset(0xE64AC707800942FF));
  }
  public IPulseRuntimeDomainValueIndex_t DomainValueIdx {
    get => new PulseRuntimeDomainValueIndex_t(_Handle + Schema.GetOffset(0xE64AC70716115525));
  }
  public IPulseRuntimeBlackboardReferenceIndex_t BlackboardReferenceIdx {
    get => new PulseRuntimeBlackboardReferenceIndex_t(_Handle + Schema.GetOffset(0xE64AC70727CB71C0));
  }


}