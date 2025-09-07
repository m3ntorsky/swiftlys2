using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CJiggleBoneUpdateNode : CUnaryUpdateNode, IJiggleBoneUpdateNode {

  public CJiggleBoneUpdateNode(nint handle) : base(handle) {
  }

  public CJiggleBoneUpdateNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IJiggleBoneSettingsList_t OpFixedData {
    get => new JiggleBoneSettingsList_t(_Handle + Schema.GetOffset(0x6CA954296960AF8C));
  }


}