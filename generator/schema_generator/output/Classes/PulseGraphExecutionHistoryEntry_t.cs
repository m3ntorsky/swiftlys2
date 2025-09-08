using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseGraphExecutionHistoryEntry_t : SchemaClass, IPulseGraphExecutionHistoryEntry_t {

  public PulseGraphExecutionHistoryEntry_t(nint handle) : base(handle) {
  }

  public IPulseCursorID_t CursorID {
    get => new PulseCursorID_t(_Handle + Schema.GetOffset(0x9346B0AB0B44CBF6));
  }
  public IPulseDocNodeID_t EditorID {
    get => new PulseDocNodeID_t(_Handle + Schema.GetOffset(0x9346B0AB74188E69));
  }
  public ref float ExecTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9346B0ABFAE08483));
  }
  public ref uint Flags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x9346B0AB5E9538F5));
  }
  public ISchemaUntypedField TagName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x9346B0ABBD7B50F8));
  }


}