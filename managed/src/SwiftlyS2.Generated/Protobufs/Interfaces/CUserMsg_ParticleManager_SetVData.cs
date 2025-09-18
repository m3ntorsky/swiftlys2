
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CUserMsg_ParticleManager_SetVData : ITypedProtobuf<CUserMsg_ParticleManager_SetVData>
{
  static CUserMsg_ParticleManager_SetVData ITypedProtobuf<CUserMsg_ParticleManager_SetVData>.Wrap(nint handle) => new CUserMsg_ParticleManager_SetVDataImpl(handle);


  public string VdataName { get; set; }

}
