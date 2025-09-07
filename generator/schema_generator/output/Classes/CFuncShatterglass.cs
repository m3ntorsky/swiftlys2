using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncShatterglass : CBaseModelEntity, IFuncShatterglass {

  public CFuncShatterglass(nint handle) : base(handle) {
  }

  public CFuncShatterglass(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref matrix3x4_t MatPanelTransform {
    get => ref _Handle.AsRef<matrix3x4_t>(Schema.GetOffset(0xB755F0FB82550F23));
  }
  public ref matrix3x4_t MatPanelTransformWsTemp {
    get => ref _Handle.AsRef<matrix3x4_t>(Schema.GetOffset(0xB755F0FB74E9192F));
  }
  public ref CUtlVector< uint32 > ShatterGlassShards {
    get => ref _Handle.AsRef<CUtlVector< uint32 >>(Schema.GetOffset(0xB755F0FBCC0BC437));
  }
  public ref Vector2D PanelSize {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0xB755F0FBC54D327C));
  }
  public IGameTime_t LastShatterSoundEmitTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xB755F0FB1708F9B9));
  }
  public IGameTime_t LastCleanupTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xB755F0FBB24E6FB0));
  }
  public IGameTime_t InitAtTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0xB755F0FBBBC7C1A5));
  }
  public ref float GlassThickness {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB755F0FB59A7355D));
  }
  public ref float SpawnInvulnerability {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB755F0FB2B3B17C1));
  }
  public ref bool BreakSilent {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB755F0FB87C0E711));
  }
  public ref bool BreakShardless {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB755F0FBC509E199));
  }
  public ref bool Broken {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB755F0FB06654200));
  }
  public ref bool GlassNavIgnore {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB755F0FBD9034606));
  }
  public ref bool GlassInFrame {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB755F0FBEB8CF645));
  }
  public ref bool StartBroken {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB755F0FBEA039156));
  }
  public ref byte InitialDamageType {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xB755F0FBED01D1E1));
  }
  public ref CUtlSymbolLarge DamagePositioningEntityName01 {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xB755F0FBADF2770D));
  }
  public ref CUtlSymbolLarge DamagePositioningEntityName02 {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xB755F0FBAAF27254));
  }
  public ref CUtlSymbolLarge DamagePositioningEntityName03 {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xB755F0FBABF273E7));
  }
  public ref CUtlSymbolLarge DamagePositioningEntityName04 {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xB755F0FBA8F26F2E));
  }
  public ref CUtlVector< Vector > InitialDamagePositions {
    get => ref _Handle.AsRef<CUtlVector< Vector >>(Schema.GetOffset(0xB755F0FB6D8C7F56));
  }
  public ref CUtlVector< Vector > ExtraDamagePositions {
    get => ref _Handle.AsRef<CUtlVector< Vector >>(Schema.GetOffset(0xB755F0FB94D38DA0));
  }
  public ref CUtlVector< Vector4D > InitialPanelVertices {
    get => ref _Handle.AsRef<CUtlVector< Vector4D >>(Schema.GetOffset(0xB755F0FB39117F58));
  }
  public IEntityIOOutput OnBroken {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xB755F0FB961F60E5));
  }
  public ref byte SurfaceType {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xB755F0FB3A6DDFE7));
  }
  public ref CStrongHandle< InfoForResourceTypeIMaterial2 > MaterialDamageBase {
    get => ref _Handle.AsRef<CStrongHandle< InfoForResourceTypeIMaterial2 >>(Schema.GetOffset(0xB755F0FB3000A1C6));
  }


}