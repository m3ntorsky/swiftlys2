using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEnvWindShared : ISchemaClass {

  
  public IGameTime_t StartTime { get; }
  
  public ref uint WindSeed { get; }
  
  public ref ushort MinWind { get; }
  
  public ref ushort MaxWind { get; }
  
  public ref int WindRadius { get; }
  
  public ref ushort MinGust { get; }
  
  public ref ushort MaxGust { get; }
  
  public ref float MinGustDelay { get; }
  
  public ref float MaxGustDelay { get; }
  
  public ref float GustDuration { get; }
  
  public ref ushort GustDirChange { get; }
  
  public ref ushort InitialWindDir { get; }
  
  public ref float InitialWindSpeed { get; }
  
  public ref Vector Location { get; }
  
  public IEntityIOOutput OnGustStart { get; }
  
  public IEntityIOOutput OnGustEnd { get; }
  
  public ref CHandle<CBaseEntity> EntOwner { get; }
}