using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CItemDefuserAlias_item_defuser : CItemDefuser, IItemDefuserAlias_item_defuser {

  public CItemDefuserAlias_item_defuser(nint handle) : base(handle) {
  }

  public CItemDefuserAlias_item_defuser(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}