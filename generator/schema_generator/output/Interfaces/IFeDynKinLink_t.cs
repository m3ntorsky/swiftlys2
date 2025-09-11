using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeDynKinLink_t : ISchemaClass {

  
  public ref ushort Parent { get; }
  
  public ref ushort Child { get; }
}