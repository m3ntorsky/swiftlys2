using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBoneConstraintDotToMorph : IBoneConstraintBase {

  
  public ref CUtlString BoneName { get; }
  
  public ref CUtlString TargetBoneName { get; }
  
  public ref CUtlString MorphChannelName { get; }
  
  public ISchemaFixedArray<float> Remap { get; }
}