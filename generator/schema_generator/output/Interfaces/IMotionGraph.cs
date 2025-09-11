using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMotionGraph : ISchemaClass {

  
  public IParamSpanUpdater ParamSpans { get; }
  
// CUtlVector< TagSpan_t >
  public ref CUtlVector Tags { get; }
  
  public ISchemaUntypedField RootNode { get; }
  
  public ref int ParameterCount { get; }
  
  public ref int ConfigStartIndex { get; }
  
  public ref int ConfigCount { get; }
  
  public ref bool Loop { get; }
}