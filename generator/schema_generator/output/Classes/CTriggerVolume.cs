using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerVolume : CBaseModelEntity, ITriggerVolume {

  public CTriggerVolume(nint handle) : base(handle) {
  }

  public ISchemaUntypedField FilterName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8A35845409C86445));
  }
  public ref CHandle<CBaseFilter> Filter {
    get => ref _Handle.AsRef<CHandle<CBaseFilter>>(Schema.GetOffset(0x8A35845445D9E0B1));
  }


}