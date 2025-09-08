using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CChicken_GraphController : CBaseAnimGraphAnimGraphController, IChicken_GraphController {

  public CChicken_GraphController(nint handle) : base(handle) {
  }

  public ISchemaUntypedField ParamActivity {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xB28E357EAA7D242F));
  }
  public ISchemaUntypedField ParamEndActivityImmediately {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xB28E357E405C8678));
  }
  public ISchemaUntypedField ActivityFinished {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xB28E357E1768F0D9));
  }
  public ISchemaUntypedField ParamTurnAngle {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xB28E357E751C028C));
  }


}