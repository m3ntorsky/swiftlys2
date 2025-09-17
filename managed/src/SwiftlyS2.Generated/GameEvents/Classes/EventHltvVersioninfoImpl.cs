using SwiftlyS2.Core.GameEvents;
using SwiftlyS2.Shared.GameEvents;
using SwiftlyS2.Shared.SchemaDefinitions;
using SwiftlyS2.Shared.GameEventDefinitions;

namespace SwiftlyS2.Core.GameEventDefinitions;

// generated
/// <summary> 
/// Event "hltv_versioninfo"
/// </summary>
internal class EventHltvVersioninfoImpl : TypedGameEvent<EventHltvVersioninfo>, EventHltvVersioninfo
{


  public int Version
  { get => Accessor.GetInt32("version"); set => Accessor.SetInt32("version", value); }
}
