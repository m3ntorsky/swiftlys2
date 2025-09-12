using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFilterContext : CBaseFilter, IFilterContext {

  public CFilterContext(nint handle) : base(handle) {
  }

  public ISchemaUntypedField FilterContext {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xA9DA7EEFF90438D1));
  }


}