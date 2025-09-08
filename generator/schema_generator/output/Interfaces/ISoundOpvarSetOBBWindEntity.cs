using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISoundOpvarSetOBBWindEntity : ISoundOpvarSetPointBase {

  public ref Vector Mins { get; }
  
  public ref Vector Maxs { get; }
  
  public ref Vector DistanceMins { get; }
  
  public ref Vector DistanceMaxs { get; }
  
  public ref float WindMin { get; }
  
  public ref float WindMax { get; }
  
  public ref float WindMapMin { get; }
  
  public ref float WindMapMax { get; }
  
}