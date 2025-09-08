using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CHostageExpresserShim : CBaseCombatCharacter, IHostageExpresserShim {

  public CHostageExpresserShim(nint handle) : base(handle) {
  }

  public IAI_Expresser Expresser {
    get => new CAI_Expresser(_Handle + Schema.GetOffset(0xD6B3DCE7697CAC2A));
  }


}