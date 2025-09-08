using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEntityInstance : SchemaClass, IEntityInstance {

  public CEntityInstance(nint handle) : base(handle) {
  }

  public ref CUtlSymbolLarge PrivateVScripts {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xB6DD442EB087F3B2));
  }
  public IScriptComponent CScriptComponent {
    get => new CScriptComponent(_Handle + Schema.GetOffset(0xB6DD442E3F4202B4));
  }

  public void EntityUpdated() {
    Schema.Update(_Handle, 0xB6DD442EA8A45978);
  }
}