using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseGraphExecutionHistory : SchemaClass, IPulseGraphExecutionHistory {

  public CPulseGraphExecutionHistory(nint handle) : base(handle) {
  }

  public IPulseGraphInstanceID_t InstanceID {
    get => new PulseGraphInstanceID_t(_Handle + Schema.GetOffset(0x2DC54ABB24192813));
  }
  public ref CUtlString StrFileName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x2DC54ABB51B717E5));
  }
  public ref CUtlVector<PointerTo<PulseGraphExecutionHistoryEntry_t>> History {
    get => ref _Handle.AsRef<CUtlVector<PointerTo<PulseGraphExecutionHistoryEntry_t>>>(Schema.GetOffset(0x2DC54ABBCFBC2CBF));
  }
  public ISchemaUntypedField MapCellDesc {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x2DC54ABB7E9FEC74));
  }
  public ISchemaUntypedField MapCursorDesc {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x2DC54ABBED035BB6));
  }


}