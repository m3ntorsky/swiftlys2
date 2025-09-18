
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_VoteSetup : ITypedProtobuf<CCSUsrMsg_VoteSetup>, INetMessage<CCSUsrMsg_VoteSetup>
{
  static int INetMessage<CCSUsrMsg_VoteSetup>.MessageId => 349;
  
  static string INetMessage<CCSUsrMsg_VoteSetup>.MessageName => "CCSUsrMsg_VoteSetup";

  static CCSUsrMsg_VoteSetup ITypedProtobuf<CCSUsrMsg_VoteSetup>.Wrap(nint handle) => new CCSUsrMsg_VoteSetupImpl(handle);


  public IProtobufRepeatedFieldValueType<string> PotentialIssues { get; }

}
