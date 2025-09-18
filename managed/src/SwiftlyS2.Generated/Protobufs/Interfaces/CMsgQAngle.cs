
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgQAngle : ITypedProtobuf<CMsgQAngle>
{
  static CMsgQAngle ITypedProtobuf<CMsgQAngle>.Wrap(nint handle) => new CMsgQAngleImpl(handle);


  public float X { get; set; }


  public float Y { get; set; }


  public float Z { get; set; }

}
