using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvEntityMaker : CPointEntity, IEnvEntityMaker {

  public CEnvEntityMaker(nint handle) : base(handle) {
  }

  public CEnvEntityMaker(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector EntityMins {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x5EC16696C39F1E27));
  }
  public ref Vector EntityMaxs {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x5EC166965CBE958D));
  }
  public ref CHandle< CBaseEntity > CurrentInstance {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x5EC166969C4BA153));
  }
  public ref CHandle< CBaseEntity > CurrentBlocker {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x5EC1669684284A72));
  }
  public ref Vector BlockerOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x5EC16696987D753F));
  }
  public ref QAngle PostSpawnDirection {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x5EC16696226D1B99));
  }
  public ref float PostSpawnDirectionVariance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5EC166965FA89D66));
  }
  public ref float PostSpawnSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5EC16696C4D43237));
  }
  public ref bool PostSpawnUseAngles {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5EC1669689448F21));
  }
  public ref CUtlSymbolLarge Template {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x5EC16696F24EC223));
  }
  public IEntityIOOutput OutputOnSpawned {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5EC1669629B86CFF));
  }
  public IEntityIOOutput OutputOnFailedSpawn {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5EC16696EBDC0A35));
  }


}