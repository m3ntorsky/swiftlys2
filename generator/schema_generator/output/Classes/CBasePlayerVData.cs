using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBasePlayerVData : CEntitySubclassVDataBase, IBasePlayerVData {

  public CBasePlayerVData(nint handle) : base(handle) {
  }

  public CBasePlayerVData(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISchemaUntypedField ModelName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x89A654F0002A227C));
  }
  public ISkillFloat HeadDamageMultiplier {
    get => new CSkillFloat(_Handle + Schema.GetOffset(0x89A654F0306CEA07));
  }
  public ISkillFloat ChestDamageMultiplier {
    get => new CSkillFloat(_Handle + Schema.GetOffset(0x89A654F0C82E808E));
  }
  public ISkillFloat StomachDamageMultiplier {
    get => new CSkillFloat(_Handle + Schema.GetOffset(0x89A654F0F84BFAFA));
  }
  public ISkillFloat ArmDamageMultiplier {
    get => new CSkillFloat(_Handle + Schema.GetOffset(0x89A654F071454291));
  }
  public ISkillFloat LegDamageMultiplier {
    get => new CSkillFloat(_Handle + Schema.GetOffset(0x89A654F0F2F8B1BB));
  }
  public ref float HoldBreathTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x89A654F093F22051));
  }
  public ref float DrowningDamageInterval {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x89A654F05ECD13F9));
  }
  public ref int DrowningDamageInitial {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x89A654F0155618A2));
  }
  public ref int DrowningDamageMax {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x89A654F0E3FA4428));
  }
  public ref int WaterSpeed {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x89A654F0CED804D7));
  }
  public ref float UseRange {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x89A654F03B375BF3));
  }
  public ref float UseAngleTolerance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x89A654F01A464300));
  }
  public ref float CrouchTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x89A654F01E805FB4));
  }


}