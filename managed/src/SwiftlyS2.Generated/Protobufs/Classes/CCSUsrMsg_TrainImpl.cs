
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CCSUsrMsg_TrainImpl : NetMessage<CCSUsrMsg_Train>, CCSUsrMsg_Train
{
  public CCSUsrMsg_TrainImpl(nint handle): base(handle)
  {
  }


  public int Train
  { get => Accessor.GetInt32("train"); set => Accessor.SetInt32("train", value); }

}
