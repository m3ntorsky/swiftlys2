
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CDataGCCStrike15_v2_TournamentMatchDraft_Entry : ITypedProtobuf<CDataGCCStrike15_v2_TournamentMatchDraft_Entry>
{
  static CDataGCCStrike15_v2_TournamentMatchDraft_Entry ITypedProtobuf<CDataGCCStrike15_v2_TournamentMatchDraft_Entry>.Wrap(nint handle) => new CDataGCCStrike15_v2_TournamentMatchDraft_EntryImpl(handle);


  public int Mapid { get; set; }


  public int TeamIdCt { get; set; }

}
