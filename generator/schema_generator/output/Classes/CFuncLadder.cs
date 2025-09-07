using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncLadder : CBaseModelEntity, IFuncLadder {

  public CFuncLadder(nint handle) : base(handle) {
  }

  public CFuncLadder(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector LadderDir {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD85E0238BEE3D218));
  }
  public ref CUtlVector< CHandle< CInfoLadderDismount > > Dismounts {
    get => ref _Handle.AsRef<CUtlVector< CHandle< CInfoLadderDismount > >>(Schema.GetOffset(0xD85E0238E1BF2F19));
  }
  public ref Vector LocalTop {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD85E0238A709E4E3));
  }
  public ref Vector PlayerMountPositionTop {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD85E02383DC07685));
  }
  public ref Vector PlayerMountPositionBottom {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD85E02387AC961B1));
  }
  public ref float AutoRideSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD85E0238B5C8CE19));
  }
  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD85E02383A7C5965));
  }
  public ref bool FakeLadder {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD85E023887708598));
  }
  public ref bool HasSlack {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD85E02381745DB1D));
  }
  public ref CUtlSymbolLarge SurfacePropName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xD85E0238749EACC6));
  }
  public IEntityIOOutput OnPlayerGotOnLadder {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xD85E02381B2BA3FC));
  }
  public IEntityIOOutput OnPlayerGotOffLadder {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xD85E02388AD8997A));
  }

  public void LadderDirUpdated() {
    Schema.Update(_Handle, 0xD85E0238BEE3D218);
  }
  public void PlayerMountPositionTopUpdated() {
    Schema.Update(_Handle, 0xD85E02383DC07685);
  }
  public void PlayerMountPositionBottomUpdated() {
    Schema.Update(_Handle, 0xD85E02387AC961B1);
  }
  public void AutoRideSpeedUpdated() {
    Schema.Update(_Handle, 0xD85E0238B5C8CE19);
  }
  public void FakeLadderUpdated() {
    Schema.Update(_Handle, 0xD85E023887708598);
  }
}