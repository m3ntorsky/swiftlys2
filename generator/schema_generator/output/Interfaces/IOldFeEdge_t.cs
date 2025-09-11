using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IOldFeEdge_t : ISchemaClass {

  
  public ISchemaFixedArray<float> K { get; }
  
  public ref float InvA { get; }
  
  public ref float T { get; }
  
  public ref float ThetaRelaxed { get; }
  
  public ref float ThetaFactor { get; }
  
  public ref float C01 { get; }
  
  public ref float C02 { get; }
  
  public ref float C03 { get; }
  
  public ref float C04 { get; }
  
  public ref float AxialModelDist { get; }
  
  public ISchemaFixedArray<float> AxialModelWeights { get; }
  
  public ISchemaFixedArray<ushort> Node { get; }
}