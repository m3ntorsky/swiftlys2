
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CDemoConsoleCmd : ITypedProtobuf<CDemoConsoleCmd>
{
  static CDemoConsoleCmd ITypedProtobuf<CDemoConsoleCmd>.Wrap(nint handle) => new CDemoConsoleCmdImpl(handle);


  public string Cmdstring { get; set; }

}
