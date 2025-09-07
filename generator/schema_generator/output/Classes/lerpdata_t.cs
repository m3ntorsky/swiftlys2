using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class lerpdata_t : SchemaClass, Ilerpdata_t {

  public lerpdata_t(nint handle) : base(handle) {
  }

  public lerpdata_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CHandle< CBaseEntity > Ent {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x70C58DAB8BBDB334));
  }
  public ref MoveType_t MoveType {
    get => ref _Handle.AsRef<MoveType_t>(Schema.GetOffset(0x70C58DAB90BCCC1C));
  }
  public IGameTime_t StartTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x70C58DAB67FE9DC4));
  }
  public ref Vector StartOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x70C58DAB7C574331));
  }
  public ref Quaternion StartRot {
    get => ref _Handle.AsRef<Quaternion>(Schema.GetOffset(0x70C58DAB6246A06D));
  }
  public IParticleIndex_t FXIndex {
    get => new ParticleIndex_t(_Handle + Schema.GetOffset(0x70C58DAB1E8452FD));
  }


}