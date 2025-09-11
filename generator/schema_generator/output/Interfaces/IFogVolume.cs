using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFogVolume : IServerOnlyModelEntity {

  
  public ref CUtlSymbolLarge FogName { get; }
  
  public ref CUtlSymbolLarge PostProcessName { get; }
  
  public ref CUtlSymbolLarge ColorCorrectionName { get; }
  
  public ref bool Disabled { get; }
  
  public ref bool InFogVolumesList { get; }
}