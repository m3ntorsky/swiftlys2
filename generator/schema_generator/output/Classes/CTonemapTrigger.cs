using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTonemapTrigger : CBaseTrigger, ITonemapTrigger {

  public CTonemapTrigger(nint handle) : base(handle) {
  }

  public ref CUtlSymbolLarge TonemapControllerName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x82562698C641A282));
  }
  public ref CEntityHandle TonemapController {
    get => ref _Handle.AsRef<CEntityHandle>(Schema.GetOffset(0x82562698F5E1A34F));
  }


}