using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IRemapValueUpdateItem : ISchemaClass {

  public IAnimParamHandle ParamIn { get; }
  
  public IAnimParamHandle ParamOut { get; }
  
  public ref float MinInputValue { get; }
  
  public ref float MaxInputValue { get; }
  
  public ref float MinOutputValue { get; }
  
  public ref float MaxOutputValue { get; }
  
}