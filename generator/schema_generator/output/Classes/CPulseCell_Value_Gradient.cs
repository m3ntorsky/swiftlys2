using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Value_Gradient : CPulseCell_BaseValue, IPulseCell_Value_Gradient {

  public CPulseCell_Value_Gradient(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Gradient {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x67D602E05C95F25));
  }


}