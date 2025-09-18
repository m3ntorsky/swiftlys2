
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CDemoRecovery : ITypedProtobuf<CDemoRecovery>
{
  static CDemoRecovery ITypedProtobuf<CDemoRecovery>.Wrap(nint handle) => new CDemoRecoveryImpl(handle);


  public CDemoRecovery_DemoInitialSpawnGroupEntry InitialSpawnGroup { get; }


  public byte[] SpawnGroupMessage { get; set; }

}
