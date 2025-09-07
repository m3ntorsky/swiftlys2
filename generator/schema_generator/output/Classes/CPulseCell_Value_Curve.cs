using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Value_Curve : CPulseCell_BaseValue, IPulseCell_Value_Curve {

  public CPulseCell_Value_Curve(nint handle) : base(handle) {
  }

  public CPulseCell_Value_Curve(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField Curve {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x63C5632D3389BB94));
  }


}