using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBlendItem_t : ISchemaClass {

  
// CUtlVector< TagSpan_t >
  public ref CUtlVector Tags { get; }
  
  public IAnimUpdateNodeRef Child { get; }
  
  public IHSequence Sequence { get; }
  
  public ref Vector2D Pos { get; }
  
  public ref float Duration { get; }
  
  public ref bool UseCustomDuration { get; }
}