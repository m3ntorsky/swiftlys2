using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CScriptComponent : CEntityComponent, IScriptComponent {

  public CScriptComponent(nint handle) : base(handle) {
  }

  public ISchemaUntypedField ScriptClassName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC922CE544F9B6681));
  }


}