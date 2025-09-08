using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSceneEventInfo : SchemaClass, ISceneEventInfo {

  public CSceneEventInfo(nint handle) : base(handle) {
  }

  public ref int Layer {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x38A9D25E0EDC14B1));
  }
  public ref int Priority {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x38A9D25E6224A30C));
  }
  public IHSequence Sequence {
    get => new HSequence(_Handle + Schema.GetOffset(0x38A9D25EE0A0598E));
  }
  public ref float Weight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x38A9D25E7B81E7AB));
  }
  public ref bool HasArrived {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x38A9D25EB10E5904));
  }
  public ref int Type {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x38A9D25E18853D59));
  }
  public IGameTime_t Next {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x38A9D25E3BE2574E));
  }
  public ref bool IsGesture {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x38A9D25E4F82B044));
  }
  public ref bool ShouldRemove {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x38A9D25E3CD02C8E));
  }
  public ref CHandle<CBaseEntity> Target {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x38A9D25ECE35901A));
  }
  public ISceneEventId_t SceneEventId {
    get => new SceneEventId_t(_Handle + Schema.GetOffset(0x38A9D25EE76A0188));
  }
  public ref bool ClientSide {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x38A9D25E6B28362D));
  }
  public ref bool Started {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x38A9D25E03CB4C7E));
  }


}