
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgConnectionStatus : ITypedProtobuf<CMsgConnectionStatus>
{
  static CMsgConnectionStatus ITypedProtobuf<CMsgConnectionStatus>.Wrap(nint handle) => new CMsgConnectionStatusImpl(handle);


  public GCConnectionStatus Status { get; set; }


  public uint ClientSessionNeed { get; set; }


  public int QueuePosition { get; set; }


  public int QueueSize { get; set; }


  public int WaitSeconds { get; set; }


  public int EstimatedWaitSecondsRemaining { get; set; }

}
