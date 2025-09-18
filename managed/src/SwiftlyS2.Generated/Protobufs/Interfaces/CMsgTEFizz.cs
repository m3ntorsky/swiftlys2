
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CMsgTEFizz : ITypedProtobuf<CMsgTEFizz>, INetMessage<CMsgTEFizz>
{
  static int INetMessage<CMsgTEFizz>.MessageId => 413;
  
  static string INetMessage<CMsgTEFizz>.MessageName => "CMsgTEFizz";

  static CMsgTEFizz ITypedProtobuf<CMsgTEFizz>.Wrap(nint handle) => new CMsgTEFizzImpl(handle);


  public int Entity { get; set; }


  public uint Density { get; set; }


  public int Current { get; set; }

}
