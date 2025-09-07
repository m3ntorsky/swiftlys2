using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PulseSelectorOutflowList_t : SchemaClass, IPulseSelectorOutflowList_t {

  public PulseSelectorOutflowList_t(nint handle) : base(handle) {
  }

  public PulseSelectorOutflowList_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< OutflowWithRequirements_t > Outflows {
    get => ref _Handle.AsRef<CUtlVector< OutflowWithRequirements_t >>(Schema.GetOffset(0x2A880DD28F0AFDF8));
  }


}