using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAttachment : ISchemaClass {

  
  public ref CUtlString Name { get; }
  
  public ISchemaFixedArray<CUtlString> InfluenceNames { get; }
  
  public ISchemaFixedArray<Quaternion> InfluenceRotations { get; }
  
  public ISchemaFixedArray<Vector> InfluenceOffsets { get; }
  
  public ISchemaFixedArray<float> InfluenceWeights { get; }
  
  public ISchemaFixedArray<bool> InfluenceRootTransform { get; }
  
  public ref byte Influences { get; }
  
  public ref bool IgnoreRotation { get; }
}