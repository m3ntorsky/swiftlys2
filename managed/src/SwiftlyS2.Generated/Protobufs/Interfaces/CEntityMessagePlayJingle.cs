
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CEntityMessagePlayJingle : ITypedProtobuf<CEntityMessagePlayJingle>
{
  static CEntityMessagePlayJingle ITypedProtobuf<CEntityMessagePlayJingle>.Wrap(nint handle) => new CEntityMessagePlayJingleImpl(handle);


  public CEntityMsg EntityMsg { get; }

}
