using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISeqMultiFetch : ISchemaClass {

  public ISeqMultiFetchFlag Flags { get; }
  
  public ref CUtlVector<short> LocalReferenceArray { get; }
  
  public ISchemaFixedArray<int> GroupSize { get; }
  
  public ISchemaFixedArray<int> LocalPose { get; }
  
  public ref CUtlVector<float> PoseKeyArray0 { get; }
  
  public ref CUtlVector<float> PoseKeyArray1 { get; }
  
  public ref int LocalCyclePoseParameter { get; }
  
  public ref bool CalculatePoseParameters { get; }
  
  public ref bool FixedBlendWeight { get; }
  
  public ISchemaFixedArray<float> FixedBlendWeightVals { get; }
  
}