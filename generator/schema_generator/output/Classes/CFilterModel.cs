using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFilterModel : CBaseFilter, IFilterModel {

  public CFilterModel(nint handle) : base(handle) {
  }

  public ISchemaUntypedField FilterModel {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x59DA03B921E36753));
  }


}