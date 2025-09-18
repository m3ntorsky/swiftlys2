
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CDemoSendTables : ITypedProtobuf<CDemoSendTables>
{
  static CDemoSendTables ITypedProtobuf<CDemoSendTables>.Wrap(nint handle) => new CDemoSendTablesImpl(handle);


  public byte[] Data { get; set; }

}
