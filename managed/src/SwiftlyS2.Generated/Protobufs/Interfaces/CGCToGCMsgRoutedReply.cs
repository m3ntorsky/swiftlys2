
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CGCToGCMsgRoutedReply : ITypedProtobuf<CGCToGCMsgRoutedReply>
{
  static CGCToGCMsgRoutedReply ITypedProtobuf<CGCToGCMsgRoutedReply>.Wrap(nint handle) => new CGCToGCMsgRoutedReplyImpl(handle);


  public uint MsgType { get; set; }


  public byte[] NetMessage { get; set; }

}
