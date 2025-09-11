using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundOpvarTraceResult_t : ISchemaClass {

  
  public ref Vector Pos { get; }
  
  public ref bool DidHit { get; }
  
  public ref float DistSqrToCenter { get; }
}