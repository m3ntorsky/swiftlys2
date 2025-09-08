using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulse_OutputConnection : SchemaClass, IPulse_OutputConnection {

  public CPulse_OutputConnection(nint handle) : base(handle) {
  }

  public ISchemaUntypedField SourceOutput {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6DEBCD452D46D7F5));
  }
  public ISchemaUntypedField TargetEntity {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6DEBCD45948B1533));
  }
  public ISchemaUntypedField TargetInput {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6DEBCD45F1A0003C));
  }
  public ISchemaUntypedField Param {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6DEBCD45E85FEBB2));
  }


}