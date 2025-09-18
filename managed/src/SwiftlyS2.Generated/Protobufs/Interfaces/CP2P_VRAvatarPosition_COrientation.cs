
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CP2P_VRAvatarPosition_COrientation : ITypedProtobuf<CP2P_VRAvatarPosition_COrientation>
{
  static CP2P_VRAvatarPosition_COrientation ITypedProtobuf<CP2P_VRAvatarPosition_COrientation>.Wrap(nint handle) => new CP2P_VRAvatarPosition_COrientationImpl(handle);


  public Vector Pos { get; set; }


  public QAngle Ang { get; set; }

}
