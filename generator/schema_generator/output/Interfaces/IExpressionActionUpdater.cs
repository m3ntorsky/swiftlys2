using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IExpressionActionUpdater : IAnimActionUpdater {

  
  public IAnimParamHandle Param { get; }
  
  public ref AnimParamType_t ParamType { get; }
  
  public IAnimScriptHandle Script { get; }
}