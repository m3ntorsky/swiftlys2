using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulse_InvokeBinding : SchemaClass, IPulse_InvokeBinding {

  public CPulse_InvokeBinding(nint handle) : base(handle) {
  }

  public CPulse_InvokeBinding(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IPulseRegisterMap_t RegisterMap {
    get => new PulseRegisterMap_t(_Handle + Schema.GetOffset(0x3632DF0D7BD4CE96));
  }
  public ISchemaUntypedField FuncName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x3632DF0D1B5BC2A4));
  }
  public IPulseRuntimeCellIndex_t CellIndex {
    get => new PulseRuntimeCellIndex_t(_Handle + Schema.GetOffset(0x3632DF0DACE41A7F));
  }
  public IPulseRuntimeChunkIndex_t SrcChunk {
    get => new PulseRuntimeChunkIndex_t(_Handle + Schema.GetOffset(0x3632DF0D313F814A));
  }
  public ref int SrcInstruction {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x3632DF0D99E09AE7));
  }


}