using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFilterClass : CBaseFilter, IFilterClass {

  public CFilterClass(nint handle) : base(handle) {
  }

  public ISchemaUntypedField FilterClass {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x31025D487FECB06));
  }


}