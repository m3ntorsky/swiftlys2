using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISSDSEndFrameViewInfo : ISchemaClass {

  public ref ulong ViewId { get; }
  
  public ref CUtlString ViewName { get; }
  
}