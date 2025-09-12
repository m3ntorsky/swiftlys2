using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBombTarget : CBaseTrigger, IBombTarget {

  public CBombTarget(nint handle) : base(handle) {
  }

  public IEntityIOOutput OnBombExplode {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1FEE3C3748E87715));
  }
  public IEntityIOOutput OnBombPlanted {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1FEE3C37B3C2496C));
  }
  public IEntityIOOutput OnBombDefused {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1FEE3C37BCDAD16E));
  }
  public ref bool IsBombSiteB {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1FEE3C37A00C3E68));
  }
  public ref bool IsHeistBombTarget {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1FEE3C374F83FD3F));
  }
  public ISchemaUntypedField MountTarget {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x1FEE3C375F784258));
  }
  public ref CHandle<CBaseEntity> InstructorHint {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x1FEE3C37D6C2F245));
  }
  public ref int BombSiteDesignation {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1FEE3C376B71EF25));
  }

  public void BombPlantedHereUpdated() {
    Schema.Update(_Handle, 0x1FEE3C37E2D52CF9);
  }
}