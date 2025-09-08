using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITriggerVolume : IBaseModelEntity {

  public ref CUtlSymbolLarge FilterName { get; }
  
  public CHandle<IBaseFilter> Filter { get; }
  
}