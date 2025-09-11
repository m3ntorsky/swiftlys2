using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvInstructorVRHint : IPointEntity {

  
  public ref CUtlSymbolLarge Name { get; }
  
  public ref CUtlSymbolLarge HintTargetEntity { get; }
  
  public ref int Timeout { get; }
  
  public ref CUtlSymbolLarge Caption { get; }
  
  public ref CUtlSymbolLarge StartSound { get; }
  
  public ref int LayoutFileType { get; }
  
  public ref CUtlSymbolLarge CustomLayoutFile { get; }
  
  public ref int AttachType { get; }
  
  public ref float HeightOffset { get; }
}