using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundeventPathCornerPairNetworked_t : ISchemaClass {

  
  public ref Vector P1 { get; }
  
  public ref Vector P2 { get; }
  
  public ref float PathLengthSqr { get; }
  
  public ref float P1Pct { get; }
  
  public ref float P2Pct { get; }
}