using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeFitMatrix_t : ISchemaClass {

  
  public ref CTransform Bone { get; }
  
  public ref Vector Center { get; }
  
  public ref ushort End { get; }
  
  public ref ushort Node { get; }
  
  public ref ushort BeginDynamic { get; }
}