using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IModelReference_t : ISchemaClass {

  
  public ref CStrongHandle<InfoForResourceTypeCModel> Model { get; }
  
  public ref float RelativeProbabilityOfSpawn { get; }
}