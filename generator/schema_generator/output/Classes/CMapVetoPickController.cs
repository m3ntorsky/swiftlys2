using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMapVetoPickController : CBaseEntity, IMapVetoPickController {

  public CMapVetoPickController(nint handle) : base(handle) {
  }

  public ref bool PlayedIntroVcd {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD5DDD68DA8EE58C9));
  }
  public ref bool NeedToPlayFiveSecondsRemaining {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD5DDD68D94B61BAD));
  }
  public ref double DblPreMatchDraftSequenceTime {
    get => ref _Handle.AsRef<double>(Schema.GetOffset(0xD5DDD68DB69AE022));
  }
  public ref bool PreMatchDraftStateChanged {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD5DDD68D114D7C7D));
  }
  public ISchemaUntypedField OnMapVetoed {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD5DDD68D6C16E77B));
  }
  public ISchemaUntypedField OnMapPicked {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD5DDD68DF50BA186));
  }
  public ISchemaUntypedField OnSidesPicked {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD5DDD68DC852D128));
  }
  public ISchemaUntypedField OnNewPhaseStarted {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD5DDD68D40B650EE));
  }
  public ISchemaUntypedField OnLevelTransition {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD5DDD68D2AEE71AD));
  }

  public void DraftTypeUpdated() {
    Schema.Update(_Handle, 0xD5DDD68D6BFCF590);
  }
  public void TeamWinningCoinTossUpdated() {
    Schema.Update(_Handle, 0xD5DDD68D45B5B5A2);
  }
  public void TeamWithFirstChoiceUpdated() {
    Schema.Update(_Handle, 0xD5DDD68D8887D005);
  }
  public void VoteMapIdsListUpdated() {
    Schema.Update(_Handle, 0xD5DDD68DE64EA3ED);
  }
  public void AccountIDsUpdated() {
    Schema.Update(_Handle, 0xD5DDD68D2F303A1A);
  }
  public void MapId0Updated() {
    Schema.Update(_Handle, 0xD5DDD68D9E2BC198);
  }
  public void MapId1Updated() {
    Schema.Update(_Handle, 0xD5DDD68D9F2BC32B);
  }
  public void MapId2Updated() {
    Schema.Update(_Handle, 0xD5DDD68DA02BC4BE);
  }
  public void MapId3Updated() {
    Schema.Update(_Handle, 0xD5DDD68DA12BC651);
  }
  public void MapId4Updated() {
    Schema.Update(_Handle, 0xD5DDD68DA22BC7E4);
  }
  public void MapId5Updated() {
    Schema.Update(_Handle, 0xD5DDD68DA32BC977);
  }
  public void StartingSide0Updated() {
    Schema.Update(_Handle, 0xD5DDD68DDAE5D5BA);
  }
  public void CurrentPhaseUpdated() {
    Schema.Update(_Handle, 0xD5DDD68DA6D9FE15);
  }
  public void PhaseStartTickUpdated() {
    Schema.Update(_Handle, 0xD5DDD68DD6F24225);
  }
  public void PhaseDurationTicksUpdated() {
    Schema.Update(_Handle, 0xD5DDD68D77B8F176);
  }
}