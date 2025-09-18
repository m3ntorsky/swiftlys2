
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CUserMessage_NotifyResponseFound_Criteria : ITypedProtobuf<CUserMessage_NotifyResponseFound_Criteria>
{
  static CUserMessage_NotifyResponseFound_Criteria ITypedProtobuf<CUserMessage_NotifyResponseFound_Criteria>.Wrap(nint handle) => new CUserMessage_NotifyResponseFound_CriteriaImpl(handle);


  public uint NameSymbol { get; set; }


  public string Value { get; set; }

}
