using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IModelBoneFlexDriverControl_t : ISchemaClass {

  
  public ref ModelBoneFlexComponent_t BoneComponent { get; }
  
  public ref CUtlString FlexController { get; }
  
  public ref uint FlexControllerToken { get; }
  
  public ref float Min { get; }
  
  public ref float Max { get; }
}