using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDestructiblePartsSystemData : ISchemaClass {

  
  public ISchemaUntypedField PartsDataByHitGroup { get; }
  
  public IRangeInt MinMaxNumberHitGroupsToDestroyWhenGibbing { get; }
}