using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IModelBoneFlexDriver_t : ISchemaClass {

  
  public ref CUtlString BoneName { get; }
  
  public ref uint BoneNameToken { get; }
  
// CUtlVector< ModelBoneFlexDriverControl_t >
  public ref CUtlVector Controls { get; }
}