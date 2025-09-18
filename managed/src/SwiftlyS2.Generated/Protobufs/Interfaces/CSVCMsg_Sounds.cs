
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CSVCMsg_Sounds : ITypedProtobuf<CSVCMsg_Sounds>, INetMessage<CSVCMsg_Sounds>
{
  static int INetMessage<CSVCMsg_Sounds>.MessageId => 49;
  
  static string INetMessage<CSVCMsg_Sounds>.MessageName => "CSVCMsg_Sounds";

  static CSVCMsg_Sounds ITypedProtobuf<CSVCMsg_Sounds>.Wrap(nint handle) => new CSVCMsg_SoundsImpl(handle);


  public bool ReliableSound { get; set; }


  public IProtobufRepeatedFieldSubMessageType<CSVCMsg_Sounds_sounddata_t> Sounds { get; }

}
