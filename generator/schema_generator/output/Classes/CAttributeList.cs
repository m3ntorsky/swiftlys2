using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAttributeList : SchemaClass, IAttributeList {

  public CAttributeList(nint handle) : base(handle) {
  }

  public CAttributeList(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVectorEmbeddedNetworkVar< CEconItemAttribute > Attributes {
    get => ref _Handle.AsRef<CUtlVectorEmbeddedNetworkVar< CEconItemAttribute >>(Schema.GetOffset(0x1028A18A7E139C14));
  }
  public IAttributeManager Manager {
    get => new CAttributeManager(_Handle + Schema.GetOffset(0x1028A18AB9A09BE6));
  }

  public void AttributesUpdated() {
    Schema.Update(_Handle, 0x1028A18A7E139C14);
  }
}