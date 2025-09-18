
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CUserMsg_ParticleManager_SetParticleText : ITypedProtobuf<CUserMsg_ParticleManager_SetParticleText>
{
  static CUserMsg_ParticleManager_SetParticleText ITypedProtobuf<CUserMsg_ParticleManager_SetParticleText>.Wrap(nint handle) => new CUserMsg_ParticleManager_SetParticleTextImpl(handle);


  public string Text { get; set; }

}
