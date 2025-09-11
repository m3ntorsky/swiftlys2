using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBasePlatTrain : IBaseToggle {

  
  public ref CUtlSymbolLarge NoiseMoving { get; }
  
  public ref CUtlSymbolLarge NoiseArrived { get; }
  
  public ref float Volume { get; }
  
  public ref float TWidth { get; }
  
  public ref float TLength { get; }
}