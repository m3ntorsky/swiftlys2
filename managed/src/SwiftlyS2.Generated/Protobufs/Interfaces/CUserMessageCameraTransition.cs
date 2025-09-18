
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CUserMessageCameraTransition : ITypedProtobuf<CUserMessageCameraTransition>, INetMessage<CUserMessageCameraTransition>
{
  static int INetMessage<CUserMessageCameraTransition>.MessageId => 143;
  
  static string INetMessage<CUserMessageCameraTransition>.MessageName => "CUserMessageCameraTransition";

  static CUserMessageCameraTransition ITypedProtobuf<CUserMessageCameraTransition>.Wrap(nint handle) => new CUserMessageCameraTransitionImpl(handle);


  public uint CameraType { get; set; }


  public float Duration { get; set; }


  public CUserMessageCameraTransition_Transition_DataDriven ParamsDataDriven { get; }

}
