using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlatTrigger : CBaseModelEntity, IPlatTrigger {

  public CPlatTrigger(nint handle) : base(handle) {
  }

  public CHandle<IFuncPlat> Platform {
    get => new CHandle<CFuncPlat>(_Handle + Schema.GetOffset(0xE5D76A656D16AFF0));
  }


}