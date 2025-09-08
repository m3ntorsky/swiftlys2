using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CItemGenericTriggerHelper : CBaseModelEntity, IItemGenericTriggerHelper {

  public CItemGenericTriggerHelper(nint handle) : base(handle) {
  }

  public CHandle<IItemGeneric> ParentItem {
    get => new CHandle<CItemGeneric>(_Handle + Schema.GetOffset(0x9E59EC5AEA0B7250));
  }


}