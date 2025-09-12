using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CGameText : CRulePointEntity, IGameText {

  public CGameText(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Message {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x8AF55797CC5243DC));
  }
  public Ihudtextparms_t TextParms {
    get => new hudtextparms_t(_Handle + Schema.GetOffset(0x8AF5579715FCA35D));
  }


}