using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseDMStart : CPointEntity, IBaseDMStart {

  public CBaseDMStart(nint handle) : base(handle) {
  }

  public CBaseDMStart(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge Master {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x4182FA98392E77B3));
  }


}