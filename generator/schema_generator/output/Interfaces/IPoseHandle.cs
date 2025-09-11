using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPoseHandle : ISchemaClass {

  
  public ref ushort Index { get; }
  
  public ref PoseType_t Type { get; }
}