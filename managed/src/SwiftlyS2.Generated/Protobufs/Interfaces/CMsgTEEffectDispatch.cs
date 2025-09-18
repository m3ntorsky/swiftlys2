
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CMsgTEEffectDispatch : ITypedProtobuf<CMsgTEEffectDispatch>, INetMessage<CMsgTEEffectDispatch>
{
  static int INetMessage<CMsgTEEffectDispatch>.MessageId => 400;
  
  static string INetMessage<CMsgTEEffectDispatch>.MessageName => "CMsgTEEffectDispatch";

  static CMsgTEEffectDispatch ITypedProtobuf<CMsgTEEffectDispatch>.Wrap(nint handle) => new CMsgTEEffectDispatchImpl(handle);


  public CMsgEffectData Effectdata { get; }

}
