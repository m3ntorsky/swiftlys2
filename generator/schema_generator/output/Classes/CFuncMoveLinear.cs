using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncMoveLinear : CBaseToggle, IFuncMoveLinear {

  public CFuncMoveLinear(nint handle) : base(handle) {
  }

  public ref MoveLinearAuthoredPos_t AuthoredPosition {
    get => ref _Handle.AsRef<MoveLinearAuthoredPos_t>(Schema.GetOffset(0xDC0EE8941BF65B84));
  }
  public ref QAngle MoveEntitySpace {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0xDC0EE894325319F9));
  }
  public ref Vector MoveDirParentSpace {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xDC0EE894EC2120EF));
  }
  public ref CUtlSymbolLarge SoundStart {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xDC0EE894E2756078));
  }
  public ref CUtlSymbolLarge SoundStop {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xDC0EE894E9EADD9C));
  }
  public ref CUtlSymbolLarge CurrentSound {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xDC0EE894C4F1FE51));
  }
  public ref float BlockDamage {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDC0EE894A5348091));
  }
  public ref float StartPosition {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDC0EE894E34367EA));
  }
  public IEntityIOOutput OnFullyOpen {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xDC0EE89421733AE4));
  }
  public IEntityIOOutput OnFullyClosed {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xDC0EE89475470294));
  }
  public ref bool CreateMovableNavMesh {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDC0EE89485442AAF));
  }
  public ref bool AllowMovableNavMeshDockingOnEntireEntity {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDC0EE8940CC0563A));
  }
  public ref bool CreateNavObstacle {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDC0EE8941849970B));
  }


}