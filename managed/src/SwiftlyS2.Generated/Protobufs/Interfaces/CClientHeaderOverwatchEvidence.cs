
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CClientHeaderOverwatchEvidence : ITypedProtobuf<CClientHeaderOverwatchEvidence>
{
  static CClientHeaderOverwatchEvidence ITypedProtobuf<CClientHeaderOverwatchEvidence>.Wrap(nint handle) => new CClientHeaderOverwatchEvidenceImpl(handle);


  public uint Accountid { get; set; }


  public ulong Caseid { get; set; }

}
