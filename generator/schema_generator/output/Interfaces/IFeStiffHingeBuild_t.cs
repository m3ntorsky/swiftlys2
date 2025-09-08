using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeStiffHingeBuild_t : ISchemaClass {

  public ref float MaxAngle { get; }
  
  public ref float Strength { get; }
  
  public ISchemaFixedArray<float> MotionBias { get; }
  
  public ISchemaFixedArray<ushort> Node { get; }
  
}