using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Inflow_Method : CPulseCell_Inflow_BaseEntrypoint, IPulseCell_Inflow_Method {

  public CPulseCell_Inflow_Method(nint handle) : base(handle) {
  }

  public ISchemaUntypedField MethodName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xFB5926557D863B13));
  }
  public ref CUtlString Description {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xFB592655678744E9));
  }
  public ref bool IsPublic {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFB592655BAE30B50));
  }
  public ISchemaUntypedField ReturnType {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xFB59265566333D67));
  }
  public ISchemaUntypedField Args {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xFB592655DAB98BBC));
  }


}