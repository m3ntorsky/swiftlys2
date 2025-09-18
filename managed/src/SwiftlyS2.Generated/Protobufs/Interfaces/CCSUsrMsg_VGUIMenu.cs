
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_VGUIMenu : ITypedProtobuf<CCSUsrMsg_VGUIMenu>, INetMessage<CCSUsrMsg_VGUIMenu>
{
  static int INetMessage<CCSUsrMsg_VGUIMenu>.MessageId => 301;
  
  static string INetMessage<CCSUsrMsg_VGUIMenu>.MessageName => "CCSUsrMsg_VGUIMenu";

  static CCSUsrMsg_VGUIMenu ITypedProtobuf<CCSUsrMsg_VGUIMenu>.Wrap(nint handle) => new CCSUsrMsg_VGUIMenuImpl(handle);


  public string Name { get; set; }


  public bool Show { get; set; }


  public IProtobufRepeatedFieldSubMessageType<CCSUsrMsg_VGUIMenu_Keys> Keys { get; }

}
