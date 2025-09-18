
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CMsgTEShatterSurface : ITypedProtobuf<CMsgTEShatterSurface>, INetMessage<CMsgTEShatterSurface>
{
  static int INetMessage<CMsgTEShatterSurface>.MessageId => 414;
  
  static string INetMessage<CMsgTEShatterSurface>.MessageName => "CMsgTEShatterSurface";

  static CMsgTEShatterSurface ITypedProtobuf<CMsgTEShatterSurface>.Wrap(nint handle) => new CMsgTEShatterSurfaceImpl(handle);


  public Vector Origin { get; set; }


  public QAngle Angles { get; set; }


  public Vector Force { get; set; }


  public Vector Forcepos { get; set; }


  public float Width { get; set; }


  public float Height { get; set; }


  public float Shardsize { get; set; }


  public uint Surfacetype { get; set; }


  public int Frontcolor { get; set; }


  public int Backcolor { get; set; }

}
