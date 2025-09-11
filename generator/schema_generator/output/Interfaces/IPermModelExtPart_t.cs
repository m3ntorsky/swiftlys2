using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPermModelExtPart_t : ISchemaClass {

  
  public ref CTransform Transform { get; }
  
  public ref CUtlString Name { get; }
  
  public ref int Parent { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCModel> RefModel { get; }
}