using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimationSnapshot_t : IAnimationSnapshotBase_t {

  public ref int EntIndex { get; }
  
  public ref CUtlString ModelName { get; }
  
}