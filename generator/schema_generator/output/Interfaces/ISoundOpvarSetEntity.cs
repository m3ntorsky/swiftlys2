using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundOpvarSetEntity : IBaseEntity {

  
  public ISchemaUntypedField StackName { get; }
  
  public ISchemaUntypedField OperatorName { get; }
  
  public ISchemaUntypedField OpvarName { get; }
  
  public ref int OpvarType { get; }
  
  public ref int OpvarIndex { get; }
  
  public ref float OpvarValue { get; }
  
  public ISchemaUntypedField OpvarValueString { get; }
  
  public ref bool SetOnSpawn { get; }
}