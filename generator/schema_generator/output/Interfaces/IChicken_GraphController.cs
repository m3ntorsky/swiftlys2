using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IChicken_GraphController : IBaseAnimGraphAnimGraphController {

  
  public ISchemaUntypedField ParamActivity { get; }
  
  public ISchemaUntypedField ParamEndActivityImmediately { get; }
  
  public ISchemaUntypedField ActivityFinished { get; }
  
  public ISchemaUntypedField ParamTurnAngle { get; }
}