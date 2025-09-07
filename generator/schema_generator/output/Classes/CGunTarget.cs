using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CGunTarget : CBaseToggle, IGunTarget {

  public CGunTarget(nint handle) : base(handle) {
  }

  public CGunTarget(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool On {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4CB42969DEB2AE70));
  }
  public ref CHandle< CBaseEntity > TargetEnt {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x4CB429692DD292D7));
  }
  public IEntityIOOutput OnDeath {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x4CB429696F756BD2));
  }


}