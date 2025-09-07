using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Unknown : CPulseCell_Base, IPulseCell_Unknown {

  public CPulseCell_Unknown(nint handle) : base(handle) {
  }

  public CPulseCell_Unknown(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField UnknownKeys {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xEA868E8A1EC86FF9));
  }


}