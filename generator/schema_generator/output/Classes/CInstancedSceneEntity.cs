using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CInstancedSceneEntity : CSceneEntity, IInstancedSceneEntity {

  public CInstancedSceneEntity(nint handle) : base(handle) {
  }

  public ref CHandle<CBaseEntity> Owner {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x2D9E341EF6D89572));
  }
  public ref bool HadOwner {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x2D9E341EB77772CD));
  }
  public ref float PostSpeakDelay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2D9E341E56890308));
  }
  public ref float PreDelay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2D9E341E0C9072B7));
  }
  public ref bool IsBackground {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x2D9E341E380A60AD));
  }
  public ref bool RemoveOnCompletion {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x2D9E341E06E2CBD6));
  }
  public ref CHandle<CBaseEntity> Target {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x2D9E341ECE35901A));
  }


}