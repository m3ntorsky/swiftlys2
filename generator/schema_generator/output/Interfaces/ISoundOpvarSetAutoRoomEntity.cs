using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundOpvarSetAutoRoomEntity : ISoundOpvarSetPointEntity {

  public ref CUtlVector TraceResults { get; }
  
  public ref CUtlVector DoorwayPairs { get; }
  
  public ref float Size { get; }
  
  public ref float HeightTolerance { get; }
  
  public ref float SizeSqr { get; }
  
}