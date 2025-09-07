using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoteController : CBaseEntity, IVoteController {

  public CVoteController(nint handle) : base(handle) {
  }

  public CVoteController(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int ActiveIssueIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6F560B06D557A463));
  }
  public ref int OnlyTeamToVote {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6F560B06C957B8C6));
  }
  public ISchemaFixedArray<int32> VoteOptionCount {
    get => new SchemaFixedArray<int32>(_Handle + Schema.GetOffset(0x6F560B0614DBD0DF));
  }
  public ref int PotentialVotes {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6F560B060198673E));
  }
  public ref bool IsYesNoVote {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6F560B069A553B97));
  }
  public ICountdownTimer AcceptingVotesTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x6F560B069E336B15));
  }
  public ICountdownTimer ExecuteCommandTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x6F560B06CAF2ECEE));
  }
  public ICountdownTimer ResetVoteTimer {
    get => new CountdownTimer(_Handle + Schema.GetOffset(0x6F560B06B54CD305));
  }
  public ISchemaFixedArray<int32> VotesCast {
    get => new SchemaFixedArray<int32>(_Handle + Schema.GetOffset(0x6F560B060247527D));
  }
  public ref CPlayerSlot PlayerHoldingVote {
    get => ref _Handle.AsRef<CPlayerSlot>(Schema.GetOffset(0x6F560B06C170B10B));
  }
  public ref CPlayerSlot PlayerOverrideForVote {
    get => ref _Handle.AsRef<CPlayerSlot>(Schema.GetOffset(0x6F560B06BF6B0097));
  }
  public ref int HighestCountIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x6F560B0602AF14EE));
  }
  public ref CUtlVector< CBaseIssue* > PotentialIssues {
    get => ref _Handle.AsRef<CUtlVector< CBaseIssue* >>(Schema.GetOffset(0x6F560B065742E1F9));
  }
  public ref CUtlVector< char* > VoteOptions {
    get => ref _Handle.AsRef<CUtlVector< char* >>(Schema.GetOffset(0x6F560B0604D2BA55));
  }

  public void ActiveIssueIndexUpdated() {
    Schema.Update(_Handle, 0x6F560B06D557A463);
  }
  public void OnlyTeamToVoteUpdated() {
    Schema.Update(_Handle, 0x6F560B06C957B8C6);
  }
  public void VoteOptionCountUpdated() {
    Schema.Update(_Handle, 0x6F560B0614DBD0DF);
  }
  public void PotentialVotesUpdated() {
    Schema.Update(_Handle, 0x6F560B060198673E);
  }
  public void IsYesNoVoteUpdated() {
    Schema.Update(_Handle, 0x6F560B069A553B97);
  }
}