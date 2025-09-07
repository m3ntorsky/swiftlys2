using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundEventEntityAlias_snd_event_point : CSoundEventEntity, ISoundEventEntityAlias_snd_event_point {

  public CSoundEventEntityAlias_snd_event_point(nint handle) : base(handle) {
  }

  public CSoundEventEntityAlias_snd_event_point(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}