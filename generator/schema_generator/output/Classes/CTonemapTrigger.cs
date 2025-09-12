using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTonemapTrigger : CBaseTrigger, ITonemapTrigger {

  public CTonemapTrigger(nint handle) : base(handle) {
  }

  public ISchemaUntypedField TonemapControllerName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x82562698C641A282));
  }
  public ref CHandle<IEntityInstance> TonemapController {
    get => ref _Handle.AsRef<CHandle<IEntityInstance>>(Schema.GetOffset(0x82562698F5E1A34F));
  }


}