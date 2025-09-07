using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSkillDamage : SchemaClass, ISkillDamage {

  public CSkillDamage(nint handle) : base(handle) {
  }

  public CSkillDamage(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISkillFloat Damage {
    get => new CSkillFloat(_Handle + Schema.GetOffset(0x6A323D82DC60E53E));
  }
  public ref float NPCDamageScalarVsNPC {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6A323D82FD135437));
  }
  public ref float PhysicsForceDamage {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6A323D8219E7630E));
  }


}