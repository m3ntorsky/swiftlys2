using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointPrefab : CServerOnlyPointEntity, IPointPrefab {

  public CPointPrefab(nint handle) : base(handle) {
  }

  public ISchemaUntypedField TargetMapName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x2C6EB7C6129742FD));
  }
  public ISchemaUntypedField ForceWorldGroupID {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x2C6EB7C61F55F68E));
  }
  public ISchemaUntypedField AssociatedRelayTargetName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x2C6EB7C6A6960E7A));
  }
  public ref bool FixupNames {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x2C6EB7C6821D8FCF));
  }
  public ref bool LoadDynamic {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x2C6EB7C6A3437F12));
  }
  public ref CHandle<CPointPrefab> AssociatedRelayEntity {
    get => ref _Handle.AsRef<CHandle<CPointPrefab>>(Schema.GetOffset(0x2C6EB7C683435943));
  }


}