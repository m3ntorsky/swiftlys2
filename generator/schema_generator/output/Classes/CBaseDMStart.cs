using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseDMStart : CPointEntity, IBaseDMStart {

  public CBaseDMStart(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Master {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x4182FA98392E77B3));
  }


}