using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCPPScriptComponentUpdater : CAnimComponentUpdater, ICPPScriptComponentUpdater {

  public CCPPScriptComponentUpdater(nint handle) : base(handle) {
  }

  public CCPPScriptComponentUpdater(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CGlobalSymbol > ScriptsToRun {
    get => ref _Handle.AsRef<CUtlVector< CGlobalSymbol >>(Schema.GetOffset(0x4785DAC8378F3E0F));
  }


}