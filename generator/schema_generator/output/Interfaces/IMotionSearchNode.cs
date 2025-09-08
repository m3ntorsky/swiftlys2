using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMotionSearchNode : ISchemaClass {

  public ref CUtlVector<PointerTo<CMotionSearchNode>> Children { get; }
  
  public IVectorQuantizer Quantizer { get; }
  
  public ref CUtlVector<CUtlVector> SampleCodes { get; }
  
  public ref CUtlVector<CUtlVector<int>> SampleIndices { get; }
  
  public ref CUtlVector<int> SelectableSamples { get; }
  
}