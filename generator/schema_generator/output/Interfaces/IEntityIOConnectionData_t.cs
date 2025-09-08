using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEntityIOConnectionData_t : ISchemaClass {

  public ref CUtlString OutputName { get; }
  
  public ref uint TargetType { get; }
  
  public ref CUtlString TargetName { get; }
  
  public ref CUtlString InputName { get; }
  
  public ref CUtlString OverrideParam { get; }
  
  public ref float Delay { get; }
  
  public ref int TimesToFire { get; }
  
  public ISchemaUntypedField ParamMap { get; }
  
}