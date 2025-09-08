using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseAnimGraphAnimGraphController : CAnimGraphControllerBase, IBaseAnimGraphAnimGraphController {

  public CBaseAnimGraphAnimGraphController(nint handle) : base(handle) {
  }

  public ISchemaUntypedField DestructiblePartDestroyedHitGroup {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x14CE6891659B7288));
  }
  public ISchemaUntypedField DestructiblePartDestroyedPartIndex {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x14CE68913BC00A58));
  }
  public ISchemaUntypedField HITGROUP_INVALID_Destroyed {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x14CE68919028C031));
  }
  public ISchemaUntypedField HITGROUP_GENERIC_Destroyed {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x14CE689176845553));
  }
  public ISchemaUntypedField HITGROUP_HEAD_Destroyed {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x14CE6891AEFB4EB4));
  }
  public ISchemaUntypedField HITGROUP_CHEST_Destroyed {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x14CE68917B0D9613));
  }
  public ISchemaUntypedField HITGROUP_STOMACH_Destroyed {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x14CE689174D1B79B));
  }
  public ISchemaUntypedField HITGROUP_LEFTARM_Destroyed {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x14CE6891FF25BE87));
  }
  public ISchemaUntypedField HITGROUP_RIGHTARM_Destroyed {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x14CE6891525B05D2));
  }
  public ISchemaUntypedField HITGROUP_LEFTLEG_Destroyed {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x14CE6891C7C4CE19));
  }
  public ISchemaUntypedField HITGROUP_RIGHTLEG_Destroyed {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x14CE68915A8CF65C));
  }
  public ISchemaUntypedField HITGROUP_NECK_Destroyed {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x14CE689195C0D851));
  }
  public ISchemaUntypedField HITGROUP_UNUSED_Destroyed {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x14CE689157414A54));
  }
  public ISchemaUntypedField HITGROUP_GEAR_Destroyed {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x14CE68918C532735));
  }
  public ISchemaUntypedField HITGROUP_SPECIAL_Destroyed {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x14CE68918FBDE7C1));
  }


}