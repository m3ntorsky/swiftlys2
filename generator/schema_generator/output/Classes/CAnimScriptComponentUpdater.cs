using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimScriptComponentUpdater : CAnimComponentUpdater, IAnimScriptComponentUpdater {

  public CAnimScriptComponentUpdater(nint handle) : base(handle) {
  }

  public IAnimScriptHandle Script {
    get => new AnimScriptHandle(_Handle + Schema.GetOffset(0x2BD2101829D70FB0));
  }


}