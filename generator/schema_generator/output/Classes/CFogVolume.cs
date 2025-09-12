using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFogVolume : CServerOnlyModelEntity, IFogVolume {

  public CFogVolume(nint handle) : base(handle) {
  }

  public ISchemaUntypedField FogName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x670FE9BC72E45F7C));
  }
  public ISchemaUntypedField PostProcessName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x670FE9BCAA94630F));
  }
  public ISchemaUntypedField ColorCorrectionName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x670FE9BC0E26708B));
  }
  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x670FE9BC3A7C5965));
  }
  public ref bool InFogVolumesList {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x670FE9BC8D7209DD));
  }


}