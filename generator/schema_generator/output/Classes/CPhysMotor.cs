using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPhysMotor : CLogicalEntity, IPhysMotor {

  public CPhysMotor(nint handle) : base(handle) {
  }

  public ref CUtlSymbolLarge NameAttach {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x88C095BFBECAEF3F));
  }
  public ref CUtlSymbolLarge NameAnchor {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x88C095BFAD43DD27));
  }
  public CHandle<IBaseEntity> AttachedObject {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x88C095BF5B0EDB58));
  }
  public CHandle<IBaseEntity> AnchorObject {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x88C095BFDE8F702D));
  }
  public ref float SpinUp {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x88C095BFB2CBE21C));
  }
  public ref float SpinDown {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x88C095BF5AA77109));
  }
  public ref float MotorFriction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x88C095BF36C3170E));
  }
  public ref float AdditionalAcceleration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x88C095BF60106F50));
  }
  public ref float AngularAcceleration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x88C095BFEB676AF1));
  }
  public ref float TorqueScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x88C095BF50218E89));
  }
  public ref float TargetSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x88C095BF9C627845));
  }
  public ref float SpeedWhenSpinUpOrSpinDownStarted {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x88C095BF86577537));
  }
  public IMotorController Motor {
    get => new CMotorController(_Handle + Schema.GetOffset(0x88C095BF373E4F92));
  }


}