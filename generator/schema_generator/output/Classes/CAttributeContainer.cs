using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAttributeContainer : CAttributeManager, IAttributeContainer {

  public CAttributeContainer(nint handle) : base(handle) {
  }

  public CAttributeContainer(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEconItemView Item {
    get => new CEconItemView(_Handle + Schema.GetOffset(0x554833CDDCE71866));
  }

  public void ItemUpdated() {
    Schema.Update(_Handle, 0x554833CDDCE71866);
  }
}