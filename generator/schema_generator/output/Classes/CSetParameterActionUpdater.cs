using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSetParameterActionUpdater : CAnimActionUpdater, ISetParameterActionUpdater {

  public CSetParameterActionUpdater(nint handle) : base(handle) {
  }

  public IAnimParamHandle Param {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x2CC56544679286A4));
  }
  public ISchemaUntypedField Value {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x2CC565446B99AEEA));
  }


}