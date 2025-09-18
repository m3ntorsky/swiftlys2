
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CP2P_Voice : ITypedProtobuf<CP2P_Voice>
{
  static CP2P_Voice ITypedProtobuf<CP2P_Voice>.Wrap(nint handle) => new CP2P_VoiceImpl(handle);


  public CMsgVoiceAudio Audio { get; }


  public uint BroadcastGroup { get; set; }

}
