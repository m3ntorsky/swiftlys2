using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CScriptComponent : CEntityComponent, IScriptComponent {

  public CScriptComponent(nint handle) : base(handle) {
  }

  public CScriptComponent(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge ScriptClassName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xC922CE544F9B6681));
  }


}