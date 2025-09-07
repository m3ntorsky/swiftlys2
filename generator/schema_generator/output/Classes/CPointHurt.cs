using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointHurt : CPointEntity, IPointHurt {

  public CPointHurt(nint handle) : base(handle) {
  }

  public CPointHurt(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int Damage {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4FEAE151C56D69C));
  }
  public ref DamageTypes_t BitsDamageType {
    get => ref _Handle.AsRef<DamageTypes_t>(Schema.GetOffset(0x4FEAE15EEAC35FC));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4FEAE155ACFC08D));
  }
  public ref float Delay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4FEAE157D68FD6E));
  }
  public ref CUtlSymbolLarge StrTarget {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x4FEAE15B8F64879));
  }
  public ref CHandle< CBaseEntity > Activator {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x4FEAE159C480B5A));
  }


}