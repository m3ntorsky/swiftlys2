using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPermEntityLumpData_t : ISchemaClass {

  
  public ref CUtlString Name { get; }
  
  public ref CUtlVector<CStrongHandle<opyable<InfoForResourceTypeCEntityLump>> ChildLumps { get; }
  
  public ref CUtlLeanVector<EntityKeyValueData_t> EntityKeyValues { get; }
}