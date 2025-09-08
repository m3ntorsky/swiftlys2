using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAttributeManager__cached_attribute_float_t : SchemaClass, IAttributeManager__cached_attribute_float_t {

  public CAttributeManager__cached_attribute_float_t(nint handle) : base(handle) {
  }

  public ref float In {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE3C5A1BAD526F734));
  }
  public ref CUtlSymbolLarge AttribHook {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xE3C5A1BACD388D67));
  }
  public ref float Out {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE3C5A1BA546B7BE1));
  }


}