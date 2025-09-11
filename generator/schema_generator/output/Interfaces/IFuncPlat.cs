using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncPlat : IBasePlatTrain {

  
  public ref CUtlSymbolLarge Noise { get; }
}