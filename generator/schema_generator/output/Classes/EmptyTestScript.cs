using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EmptyTestScript : CAnimScriptBase, IEmptyTestScript {

  public EmptyTestScript(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Test {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xB7F6B6D5FAAC6DA3));
  }


}