using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFilterAttributeInt : CBaseFilter, IFilterAttributeInt {

  public CFilterAttributeInt(nint handle) : base(handle) {
  }

  public ref CUtlSymbolLarge AttributeName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x7CC26955E63BC84D));
  }


}