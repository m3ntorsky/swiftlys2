using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ITestEffect : IBaseEntity {

  
  public ref int Loop { get; }
  
  public ref int Beam { get; }
  
  public IBeam Beam { get; }
  
  public IGameTime_t BeamTime { get; }
  
  public IGameTime_t StartTime { get; }
}