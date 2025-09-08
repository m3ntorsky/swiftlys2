using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimFrameSegment : ISchemaClass {

  public ref int UniqueFrameIndex { get; }
  
  public ref uint LocalElementMasks { get; }
  
  public ref int LocalChannel { get; }
  
  public ref CUtlBinaryBlock Container { get; }
  
}