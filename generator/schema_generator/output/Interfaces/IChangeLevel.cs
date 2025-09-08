using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IChangeLevel : IBaseTrigger {

  public ref CUtlString MapName { get; }
  
  public ref CUtlString LandmarkName { get; }
  
  public IEntityIOOutput OnChangeLevel { get; }
  
  public ref bool Touched { get; }
  
  public ref bool NoTouch { get; }
  
  public ref bool NewChapter { get; }
  
  public ref bool OnChangeLevelFired { get; }
  
}