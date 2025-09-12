using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTankTargetChange : CPointEntity, ITankTargetChange {

  public CTankTargetChange(nint handle) : base(handle) {
  }

  public ISchemaUntypedField NewTarget {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC9633A4FC35D87C4));
  }
  public ISchemaUntypedField NewTargetName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC9633A4FFCD3FD1F));
  }


}