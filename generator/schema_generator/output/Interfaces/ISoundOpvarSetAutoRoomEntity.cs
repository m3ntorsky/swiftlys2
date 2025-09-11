using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundOpvarSetAutoRoomEntity : ISoundOpvarSetPointEntity {

  
// CUtlVector< SoundOpvarTraceResult_t >
  public ref CUtlVector TraceResults { get; }
  
// CUtlVector< AutoRoomDoorwayPairs_t >
  public ref CUtlVector DoorwayPairs { get; }
  
  public ref float Size { get; }
  
  public ref float HeightTolerance { get; }
  
  public ref float SizeSqr { get; }
}