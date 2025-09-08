using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IColorCorrectionVolume : IBaseTrigger {

  public ref float MaxWeight { get; }
  
  public ref float FadeDuration { get; }
  
  public ref float Weight { get; }
  
  public ISchemaFixedString LookupFilename { get; }
  
  public ref float LastEnterWeight { get; }
  
  public IGameTime_t LastEnterTime { get; }
  
  public ref float LastExitWeight { get; }
  
  public IGameTime_t LastExitTime { get; }
  
}