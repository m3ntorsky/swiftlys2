using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFish : CBaseAnimGraph, IFish {

  public CFish(nint handle) : base(handle) {
  }

  public CFish(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CHandle< CFishPool > Pool {
    get => ref _Handle.AsRef<CHandle< CFishPool >>(Schema.GetOffset(0xC43C8434366BF523));
  }
  public ref uint Id {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xC43C8434B4B6E980));
  }
  public ref float X {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC43C8434DBC57BA7));
  }
  public ref float Y {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC43C8434DAC57A14));
  }
  public ref float Z {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC43C8434DDC57ECD));
  }
  public ref float Angle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC43C8434D4164938));
  }
  public ref float AngleChange {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC43C84343E25ADF0));
  }
  public ref Vector Forward {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xC43C84348C0AF53A));
  }
  public ref Vector Perp {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xC43C8434607EC05C));
  }
  public ref Vector PoolOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xC43C843442AD682D));
  }
  public ref float WaterLevel {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC43C8434E63A21D6));
  }
  public ref float Speed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC43C8434A4BD35A0));
  }
  public ref float DesiredSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC43C843492BBF450));
  }
  public ref float CalmSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC43C84340BF88DE9));
  }
  public ref float PanicSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC43C8434270FACBF));
  }
  public ref float AvoidRange {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC43C84346BCFA4EB));
  }
  public ICountdownTimer TurnTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0xC43C8434700B062B));
  }
  public ref bool TurnClockwise {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC43C8434C5ECCED4));
  }
  public ICountdownTimer GoTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0xC43C84348CBF9730));
  }
  public ICountdownTimer MoveTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0xC43C8434254C6AC5));
  }
  public ICountdownTimer PanicTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0xC43C8434D2FFC665));
  }
  public ICountdownTimer DisperseTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0xC43C8434C8E05E9F));
  }
  public ICountdownTimer ProximityTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0xC43C8434ABE32A63));
  }
  public ref CUtlVector< CFish* > Visible {
    get => ref _Handle.AsRef<CUtlVector< CFish* >>(Schema.GetOffset(0xC43C8434002CBAC1));
  }

  public void XUpdated() {
    Schema.Update(_Handle, 0xC43C8434DBC57BA7);
  }
  public void YUpdated() {
    Schema.Update(_Handle, 0xC43C8434DAC57A14);
  }
  public void ZUpdated() {
    Schema.Update(_Handle, 0xC43C8434DDC57ECD);
  }
  public void AngleUpdated() {
    Schema.Update(_Handle, 0xC43C8434D4164938);
  }
  public void PoolOriginUpdated() {
    Schema.Update(_Handle, 0xC43C843442AD682D);
  }
  public void WaterLevelUpdated() {
    Schema.Update(_Handle, 0xC43C8434E63A21D6);
  }
}