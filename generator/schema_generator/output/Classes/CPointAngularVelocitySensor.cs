using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointAngularVelocitySensor : CPointEntity, IPointAngularVelocitySensor {

  public CPointAngularVelocitySensor(nint handle) : base(handle) {
  }

  public ref CHandle<CBaseEntity> TargetEntity {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x5B09D8F25D042A9));
  }
  public ref float Threshold {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5B09D8F7872FFEA));
  }
  public ref int LastCompareResult {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5B09D8F696B400D));
  }
  public ref int LastFireResult {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5B09D8FBC50E238));
  }
  public IGameTime_t FireTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x5B09D8F873CD172));
  }
  public ref float FireInterval {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5B09D8F1B1AA6D2));
  }
  public ref float LastAngVelocity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5B09D8F10D82166));
  }
  public ref QAngle LastOrientation {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x5B09D8FBB4E87E5));
  }
  public ref Vector Axis {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x5B09D8F0AF9CE54));
  }
  public ref bool UseHelper {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5B09D8F7370F54C));
  }
  public ISchemaUntypedField AngularVelocity {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x5B09D8FA4D9E2BE));
  }
  public IEntityIOOutput OnLessThan {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5B09D8FB6AC02FE));
  }
  public IEntityIOOutput OnLessThanOrEqualTo {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5B09D8F28E696D8));
  }
  public IEntityIOOutput OnGreaterThan {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5B09D8F50BD472D));
  }
  public IEntityIOOutput OnGreaterThanOrEqualTo {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5B09D8F6483CABD));
  }
  public IEntityIOOutput OnEqualTo {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5B09D8F87EEC581));
  }


}