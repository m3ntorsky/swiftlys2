using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeAntiTunnelProbe_t : ISchemaClass {

  public ref float Weight { get; }
  
  public ref uint Flags { get; }
  
  public ref ushort ProbeNode { get; }
  
  public ref ushort Count { get; }
  
  public ref uint Begin { get; }
  
  public ref float ActivationDistance { get; }
  
  public ref float CurvatureRadius { get; }
  
  public ref float Bias { get; }
  
}