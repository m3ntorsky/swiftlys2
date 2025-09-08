using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulse_CallInfo : SchemaClass, IPulse_CallInfo {

  public CPulse_CallInfo(nint handle) : base(handle) {
  }

  public ISchemaUntypedField PortName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6ADF88D807237B65));
  }
  public IPulseDocNodeID_t EditorNodeID {
    get => new PulseDocNodeID_t(_Handle + Schema.GetOffset(0x6ADF88D88D964CBD));
  }
  public IPulseRegisterMap_t RegisterMap {
    get => new PulseRegisterMap_t(_Handle + Schema.GetOffset(0x6ADF88D87BD4CE96));
  }
  public IPulseDocNodeID_t CallMethodID {
    get => new PulseDocNodeID_t(_Handle + Schema.GetOffset(0x6ADF88D805714471));
  }
  public IPulseRuntimeChunkIndex_t SrcChunk {
    get => new PulseRuntimeChunkIndex_t(_Handle + Schema.GetOffset(0x6ADF88D8313F814A));
  }
  public ref int SrcInstruction {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6ADF88D899E09AE7));
  }


}