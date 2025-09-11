using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILookAtBone_t : ISchemaClass {

  
  public ref int Index { get; }
  
  public ref float Weight { get; }
}