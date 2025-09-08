using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerLook : CTriggerOnce, ITriggerLook {

  public CTriggerLook(nint handle) : base(handle) {
  }

  public ref CHandle<CBaseEntity> LookTarget {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x400CA6913361F745));
  }
  public ref float FieldOfView {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x400CA69157C8F26D));
  }
  public ref float LookTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x400CA69104D9B055));
  }
  public ref float LookTimeTotal {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x400CA6910EF1464D));
  }
  public IGameTime_t LookTimeLast {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x400CA691C3304509));
  }
  public ref float TimeoutDuration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x400CA6919AF6CDFE));
  }
  public ref bool TimeoutFired {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x400CA69169DF01E8));
  }
  public ref bool IsLooking {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x400CA691983E8E2A));
  }
  public ref bool B2DFOV {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x400CA6919C4430D2));
  }
  public ref bool UseVelocity {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x400CA6915E806BAF));
  }
  public IEntityIOOutput OnTimeout {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x400CA691C5301603));
  }
  public IEntityIOOutput OnStartLook {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x400CA6914E36D787));
  }
  public IEntityIOOutput OnEndLook {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x400CA6914D4626E6));
  }

  public void TestOcclusionUpdated() {
    Schema.Update(_Handle, 0x400CA6912AB3E7C2);
  }
  public void TestAllVisibleOcclusionUpdated() {
    Schema.Update(_Handle, 0x400CA691FBAABAEB);
  }
}