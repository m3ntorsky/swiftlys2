using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlatTrigger : CBaseModelEntity, IPlatTrigger {

  public CPlatTrigger(nint handle) : base(handle) {
  }

  public CPlatTrigger(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CHandle< CFuncPlat > Platform {
    get => ref _Handle.AsRef<CHandle< CFuncPlat >>(Schema.GetOffset(0xE5D76A656D16AFF0));
  }


}