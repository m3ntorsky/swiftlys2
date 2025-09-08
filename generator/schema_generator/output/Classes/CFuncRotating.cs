using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncRotating : CBaseModelEntity, IFuncRotating {

  public CFuncRotating(nint handle) : base(handle) {
  }

  public IEntityIOOutput OnStopped {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1A29EA94161C44C9));
  }
  public IEntityIOOutput OnStarted {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1A29EA94328D617D));
  }
  public IEntityIOOutput OnReachedStart {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1A29EA945C72A242));
  }
  public ISchemaUntypedField LocalRotationVector {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x1A29EA946ACE06C5));
  }
  public ref float FanFriction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1A29EA9446523D02));
  }
  public ref float Attenuation {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1A29EA94D112ECE1));
  }
  public ref float Volume {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1A29EA947647E0C9));
  }
  public ref float TargetSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1A29EA949C627845));
  }
  public ref float MaxSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1A29EA94EC4C9592));
  }
  public ref float BlockDamage {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1A29EA94A5348091));
  }
  public ref CUtlSymbolLarge NoiseRunning {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x1A29EA943C33F758));
  }
  public ref bool Reversed {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1A29EA945A005113));
  }
  public ref bool AccelDecel {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1A29EA941765B278));
  }
  public ref QAngle PrevLocalAngles {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x1A29EA9494C1668B));
  }
  public ref QAngle Start {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x1A29EA947AE5D8A1));
  }
  public ref bool StopAtStartPos {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1A29EA944E6241BE));
  }
  public ref Vector ClientOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1A29EA9470D96068));
  }
  public ref QAngle ClientAngles {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x1A29EA94F6CF85C2));
  }


}