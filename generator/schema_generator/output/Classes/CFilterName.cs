using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFilterName : CBaseFilter, IFilterName {

  public CFilterName(nint handle) : base(handle) {
  }

  public ISchemaUntypedField FilterName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xF129410709C86445));
  }


}