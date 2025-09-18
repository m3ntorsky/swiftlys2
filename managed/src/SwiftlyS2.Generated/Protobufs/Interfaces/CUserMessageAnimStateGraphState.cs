
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CUserMessageAnimStateGraphState : ITypedProtobuf<CUserMessageAnimStateGraphState>
{
  static CUserMessageAnimStateGraphState ITypedProtobuf<CUserMessageAnimStateGraphState>.Wrap(nint handle) => new CUserMessageAnimStateGraphStateImpl(handle);


  public int EntityIndex { get; set; }


  public byte[] Data { get; set; }

}
