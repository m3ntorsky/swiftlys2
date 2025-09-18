
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CMsgSosStartSoundEventImpl : NetMessage<CMsgSosStartSoundEvent>, CMsgSosStartSoundEvent
{
  public CMsgSosStartSoundEventImpl(nint handle): base(handle)
  {
  }


  public int SoundeventGuid
  { get => Accessor.GetInt32("soundevent_guid"); set => Accessor.SetInt32("soundevent_guid", value); }


  public int SoundeventHash
  { get => Accessor.GetInt32("soundevent_hash"); set => Accessor.SetInt32("soundevent_hash", value); }


  public int SourceEntityIndex
  { get => Accessor.GetInt32("source_entity_index"); set => Accessor.SetInt32("source_entity_index", value); }


  public int Seed
  { get => Accessor.GetInt32("seed"); set => Accessor.SetInt32("seed", value); }


  public byte[] PackedParams
  { get => Accessor.GetBytes("packed_params"); set => Accessor.SetBytes("packed_params", value); }


  public float StartTime
  { get => Accessor.GetFloat("start_time"); set => Accessor.SetFloat("start_time", value); }

}
