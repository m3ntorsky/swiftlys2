using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDestructiblePartsSystemData_DamageLevel : SchemaClass, IDestructiblePartsSystemData_DamageLevel {

  public CDestructiblePartsSystemData_DamageLevel(nint handle) : base(handle) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x4191C15D63D22D49));
  }
  public ref CGlobalSymbol BreakablePieceName {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x4191C15D88329BEA));
  }
  public ref int BodyGroupValue {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4191C15D90FF4BE9));
  }
  public ISkillInt Health {
    get => new CSkillInt(_Handle + Schema.GetOffset(0x4191C15D6E9C4CC3));
  }
  public ref EDestructiblePartDamagePassThroughType DamagePassthroughType {
    get => ref _Handle.AsRef<EDestructiblePartDamagePassThroughType>(Schema.GetOffset(0x4191C15D3D01100A));
  }
  public ref DestructiblePartDestructionDeathBehavior_t DestructionDeathBehavior {
    get => ref _Handle.AsRef<DestructiblePartDestructionDeathBehavior_t>(Schema.GetOffset(0x4191C15D41778385));
  }
  public ref CGlobalSymbol CustomDeathHandshake {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x4191C15DF17A0D42));
  }
  public ref bool ShouldDestroyOnDeath {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4191C15DC63DDDD5));
  }
  public IRangeFloat DeathDestroyTime {
    get => new CRangeFloat(_Handle + Schema.GetOffset(0x4191C15D29D83EA2));
  }


}