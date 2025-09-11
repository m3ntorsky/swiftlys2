using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDampedValueUpdateItem : ISchemaClass {

  
  public IAnimInputDamping Damping { get; }
  
  public IAnimParamHandle ParamIn { get; }
  
  public IAnimParamHandle ParamOut { get; }
}