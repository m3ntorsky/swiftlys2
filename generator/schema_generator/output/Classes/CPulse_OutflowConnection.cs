using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulse_OutflowConnection : SchemaClass, IPulse_OutflowConnection {

  public CPulse_OutflowConnection(nint handle) : base(handle) {
  }

  public CPulse_OutflowConnection(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField SourceOutflowName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x58023C685EA2FFCF));
  }
  public IPulseRuntimeChunkIndex_t DestChunk {
    get => new PulseRuntimeChunkIndex_t(_Handle + Schema.GetOffset(0x58023C68D6AC502E));
  }
  public ref int Instruction {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x58023C6890E63133));
  }
  public IPulseRegisterMap_t OutflowRegisterMap {
    get => new PulseRegisterMap_t(_Handle + Schema.GetOffset(0x58023C68F89A90F8));
  }


}