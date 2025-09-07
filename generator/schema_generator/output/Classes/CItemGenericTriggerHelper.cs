using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CItemGenericTriggerHelper : CBaseModelEntity, IItemGenericTriggerHelper {

  public CItemGenericTriggerHelper(nint handle) : base(handle) {
  }

  public CItemGenericTriggerHelper(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CHandle< CItemGeneric > ParentItem {
    get => ref _Handle.AsRef<CHandle< CItemGeneric >>(Schema.GetOffset(0x9E59EC5AEA0B7250));
  }


}