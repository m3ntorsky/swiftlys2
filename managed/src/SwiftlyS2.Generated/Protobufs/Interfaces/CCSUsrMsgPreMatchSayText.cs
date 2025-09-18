
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CCSUsrMsgPreMatchSayText : ITypedProtobuf<CCSUsrMsgPreMatchSayText>
{
  static CCSUsrMsgPreMatchSayText ITypedProtobuf<CCSUsrMsgPreMatchSayText>.Wrap(nint handle) => new CCSUsrMsgPreMatchSayTextImpl(handle);


  public uint AccountId { get; set; }


  public string Text { get; set; }


  public bool AllChat { get; set; }

}
