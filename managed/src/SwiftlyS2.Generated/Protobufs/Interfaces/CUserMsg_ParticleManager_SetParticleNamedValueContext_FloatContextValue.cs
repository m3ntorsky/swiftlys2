
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CUserMsg_ParticleManager_SetParticleNamedValueContext_FloatContextValue : ITypedProtobuf<CUserMsg_ParticleManager_SetParticleNamedValueContext_FloatContextValue>
{
  static CUserMsg_ParticleManager_SetParticleNamedValueContext_FloatContextValue ITypedProtobuf<CUserMsg_ParticleManager_SetParticleNamedValueContext_FloatContextValue>.Wrap(nint handle) => new CUserMsg_ParticleManager_SetParticleNamedValueContext_FloatContextValueImpl(handle);


  public uint ValueNameHash { get; set; }


  public float Value { get; set; }

}
