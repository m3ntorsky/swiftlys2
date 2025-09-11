using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimationDecodeDebugDump_t : ISchemaClass {

  
  public ref AnimationProcessingType_t ProcessingType { get; }
  
// CUtlVector< AnimationDecodeDebugDumpElement_t >
  public ref CUtlVector Elems { get; }
}