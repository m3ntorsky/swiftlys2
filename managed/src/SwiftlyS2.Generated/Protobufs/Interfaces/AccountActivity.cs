
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface AccountActivity : ITypedProtobuf<AccountActivity>
{
  static AccountActivity ITypedProtobuf<AccountActivity>.Wrap(nint handle) => new AccountActivityImpl(handle);


  public uint Activity { get; set; }


  public uint Mode { get; set; }


  public uint Map { get; set; }


  public ulong Matchid { get; set; }

}
