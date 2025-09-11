using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvWindController : IBaseEntity {

  
  public IEnvWindShared EnvWindShared { get; }
  
  public ref float DirectionVariation { get; }
  
  public ref float SpeedVariation { get; }
  
  public ref float Turbulence { get; }
  
  public ref float VolumeHalfExtentXY { get; }
  
  public ref float VolumeHalfExtentZ { get; }
  
  public ref int VolumeResolutionXY { get; }
  
  public ref int VolumeResolutionZ { get; }
  
  public ref int ClipmapLevels { get; }
  
  public ref bool IsMaster { get; }
  
  public ref bool FirstTime { get; }
}