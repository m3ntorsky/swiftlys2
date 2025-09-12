using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDynamicProp : CBreakableProp, IDynamicProp {

  public CDynamicProp(nint handle) : base(handle) {
  }

  public ref bool CreateNavObstacle {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6A5171A21849970B));
  }
  public ref bool NavObstacleUpdatesOverridden {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6A5171A2B1954B9B));
  }
  public IEntityIOOutput OutputAnimBegun {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x6A5171A28FAC5E08));
  }
  public IEntityIOOutput OutputAnimOver {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x6A5171A2EA12DDC9));
  }
  public IEntityIOOutput OutputAnimLoopCycleOver {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x6A5171A2333A0537));
  }
  public IEntityIOOutput OnAnimReachedStart {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x6A5171A22545BE4B));
  }
  public IEntityIOOutput OnAnimReachedEnd {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x6A5171A2E4470C0E));
  }
  public ISchemaUntypedField IdleAnim {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6A5171A22885C0E2));
  }
  public ref AnimLoopMode_t IdleAnimLoopMode {
    get => ref _Handle.AsRef<AnimLoopMode_t>(Schema.GetOffset(0x6A5171A2D07822E7));
  }
  public ref bool RandomizeCycle {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6A5171A247A89442));
  }
  public ref bool StartDisabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6A5171A261ED0C4F));
  }
  public ref bool FiredStartEndOutput {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6A5171A2B8178D13));
  }
  public ref bool ForceNpcExclude {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6A5171A24194963F));
  }
  public ref bool CreateNonSolid {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6A5171A25FFEA7EB));
  }
  public ref bool IsOverrideProp {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6A5171A243F03A10));
  }
  public ref int InitialGlowState {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6A5171A25260376A));
  }
  public ref int GlowRange {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6A5171A2D03F97ED));
  }
  public ref int GlowRangeMin {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6A5171A2A28EDB1F));
  }
  public ref Color GlowColor {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0x6A5171A274A5EE03));
  }
  public ref int GlowTeam {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6A5171A2E7C1E481));
  }

  public void UseHitboxesForRenderBoxUpdated() {
    Schema.Update(_Handle, 0x6A5171A2F0B849FA);
  }
  public void UseAnimGraphUpdated() {
    Schema.Update(_Handle, 0x6A5171A208993DDB);
  }
}