using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseGraphExecutionHistoryNodeDesc_t : SchemaClass, IPulseGraphExecutionHistoryNodeDesc_t {

  public PulseGraphExecutionHistoryNodeDesc_t(nint handle) : base(handle) {
  }

  public PulseGraphExecutionHistoryNodeDesc_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CBufferString StrCellDesc {
    get => ref _Handle.AsRef<CBufferString>(Schema.GetOffset(0x7F4ECA02AD3F01DD));
  }
  public ISchemaUntypedField StrBindingName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x7F4ECA021A5069AA));
  }


}