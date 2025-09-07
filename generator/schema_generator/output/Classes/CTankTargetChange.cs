using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTankTargetChange : CPointEntity, ITankTargetChange {

  public CTankTargetChange(nint handle) : base(handle) {
  }

  public CTankTargetChange(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField NewTarget {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC9633A4FC35D87C4));
  }
  public ref CUtlSymbolLarge NewTargetName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xC9633A4FFCD3FD1F));
  }


}