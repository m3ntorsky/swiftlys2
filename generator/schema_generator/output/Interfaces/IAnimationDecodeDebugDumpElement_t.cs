using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimationDecodeDebugDumpElement_t : ISchemaClass {

  public ref int EntityIndex { get; }
  
  public ref CUtlString ModelName { get; }
  
  public ref CUtlVector<CUtlString> PoseParams { get; }
  
  public ref CUtlVector<CUtlString> DecodeOps { get; }
  
  public ref CUtlVector<CUtlString> InternalOps { get; }
  
  public ref CUtlVector<CUtlString> DecodedAnims { get; }
  
}