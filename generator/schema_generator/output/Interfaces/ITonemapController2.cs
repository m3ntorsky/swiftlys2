using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITonemapController2 : IBaseEntity {

  
  public ref float AutoExposureMin { get; }
  
  public ref float AutoExposureMax { get; }
  
  public ref float ExposureAdaptationSpeedUp { get; }
  
  public ref float ExposureAdaptationSpeedDown { get; }
  
  public ref float TonemapEVSmoothingRange { get; }
}