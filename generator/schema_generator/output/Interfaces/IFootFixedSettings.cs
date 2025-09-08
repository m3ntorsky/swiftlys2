using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootFixedSettings : ISchemaClass {

  public ITraceSettings_t TraceSettings { get; }
  
  public ref VectorAligned FootBaseBindPosePositionMS { get; }
  
  public ref float FootBaseLength { get; }
  
  public ref float MaxRotationLeft { get; }
  
  public ref float MaxRotationRight { get; }
  
  public ref int FootstepLandedTagIndex { get; }
  
  public ref bool EnableTracing { get; }
  
  public ref float TraceAngleBlend { get; }
  
  public ref int DisableTagIndex { get; }
  
  public ref int FootIndex { get; }
  
}