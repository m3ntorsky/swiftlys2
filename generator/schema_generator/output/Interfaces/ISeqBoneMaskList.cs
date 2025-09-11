using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISeqBoneMaskList : ISchemaClass {

  
  public ref CBufferString Name { get; }
  
  public ref CUtlVector<short> LocalBoneArray { get; }
  
  public ref CUtlVector<float> BoneWeightArray { get; }
  
  public ref float DefaultMorphCtrlWeight { get; }
  
// CUtlVector< std::pair< CBufferString, float32 > >
  public ref CUtlVector MorphCtrlWeightArray { get; }
}