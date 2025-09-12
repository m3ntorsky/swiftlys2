using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPropDataComponent : CEntityComponent, IPropDataComponent {

  public CPropDataComponent(nint handle) : base(handle) {
  }

  public ref float DmgModBullet {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE413EBB77495F));
  }
  public ref float DmgModClub {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE413E1C404FB7));
  }
  public ref float DmgModExplosive {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE413E0E90F97E));
  }
  public ref float DmgModFire {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1CFE413E7E842D23));
  }
  public ISchemaUntypedField PhysicsDamageTableName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x1CFE413E7A45F0E2));
  }
  public ISchemaUntypedField BasePropData {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x1CFE413EBF60E2A1));
  }
  public ref int Interactions {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1CFE413EE8050E44));
  }
  public ref bool SpawnMotionDisabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1CFE413E87EB2E82));
  }
  public ref int DisableTakePhysicsDamageSpawnFlag {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1CFE413E5D3DCAE1));
  }
  public ref int MotionDisabledSpawnFlag {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1CFE413ECBDEA450));
  }


}