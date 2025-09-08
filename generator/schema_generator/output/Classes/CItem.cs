using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CItem : CBaseAnimGraph, IItem {

  public CItem(nint handle) : base(handle) {
  }

  public IEntityIOOutput OnPlayerTouch {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x20C89FC926AD34F8));
  }
  public IEntityIOOutput OnPlayerPickup {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x20C89FC9DE81BF25));
  }
  public ref bool ActivateWhenAtRest {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x20C89FC982B8CCFF));
  }
  public IEntityIOOutput OnCacheInteraction {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x20C89FC9FB2A1C2A));
  }
  public IEntityIOOutput OnGlovePulled {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x20C89FC928CF9923));
  }
  public ref Vector OriginalSpawnOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x20C89FC9B6F410AF));
  }
  public ref QAngle OriginalSpawnAngles {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x20C89FC9F7A16BD1));
  }
  public ref bool PhysStartAsleep {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x20C89FC94BB7E9FD));
  }


}