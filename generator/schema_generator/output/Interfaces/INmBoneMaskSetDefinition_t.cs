using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmBoneMaskSetDefinition_t : ISchemaClass {

  public ref CGlobalSymbol ID { get; }
  
  public INmBoneWeightList PrimaryWeightList { get; }
  
  public ref CUtlLeanVector<CNmBoneWeightList> SecondaryWeightLists { get; }
  
}