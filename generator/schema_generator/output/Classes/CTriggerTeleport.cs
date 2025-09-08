using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerTeleport : CBaseTrigger, ITriggerTeleport {

  public CTriggerTeleport(nint handle) : base(handle) {
  }

  public ref CUtlSymbolLarge Landmark {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xA6381755DF022EC4));
  }
  public ref bool UseLandmarkAngles {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA638175528C3B2F4));
  }
  public ref bool MirrorPlayer {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA638175563293A1B));
  }
  public ref bool CheckDestIfClearForPlayer {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA638175514792115));
  }


}