using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimAttachment : ISchemaClass {

  public ISchemaFixedArray<Quaternion> InfluenceRotations { get; }
  
  public ISchemaFixedArray<VectorAligned> InfluenceOffsets { get; }
  
  public ISchemaFixedArray<int> InfluenceIndices { get; }
  
  public ISchemaFixedArray<float> InfluenceWeights { get; }
  
  public ref byte NumInfluences { get; }
  
}