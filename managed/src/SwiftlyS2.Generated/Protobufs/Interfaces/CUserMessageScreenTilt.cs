
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CUserMessageScreenTilt : ITypedProtobuf<CUserMessageScreenTilt>, INetMessage<CUserMessageScreenTilt>
{
  static int INetMessage<CUserMessageScreenTilt>.MessageId => 125;
  
  static string INetMessage<CUserMessageScreenTilt>.MessageName => "CUserMessageScreenTilt";

  static CUserMessageScreenTilt ITypedProtobuf<CUserMessageScreenTilt>.Wrap(nint handle) => new CUserMessageScreenTiltImpl(handle);


  public uint Command { get; set; }


  public bool EaseInOut { get; set; }


  public Vector Angle { get; set; }


  public float Duration { get; set; }


  public float Time { get; set; }

}
