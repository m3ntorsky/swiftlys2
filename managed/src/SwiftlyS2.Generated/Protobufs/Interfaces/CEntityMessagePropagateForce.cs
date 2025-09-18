
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CEntityMessagePropagateForce : ITypedProtobuf<CEntityMessagePropagateForce>
{
  static CEntityMessagePropagateForce ITypedProtobuf<CEntityMessagePropagateForce>.Wrap(nint handle) => new CEntityMessagePropagateForceImpl(handle);


  public Vector Impulse { get; set; }


  public CEntityMsg EntityMsg { get; }

}
