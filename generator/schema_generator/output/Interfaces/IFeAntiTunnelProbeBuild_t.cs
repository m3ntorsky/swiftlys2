using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeAntiTunnelProbeBuild_t : ISchemaClass {

  
  public ref float Weight { get; }
  
  public ref float ActivationDistance { get; }
  
  public ref float Bias { get; }
  
  public ref float Curvature { get; }
  
  public ref uint Flags { get; }
  
  public ref ushort ProbeNode { get; }
  
  public ref CUtlVector<ushort> TargetNodes { get; }
}