using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointCommentaryNode : CBaseAnimGraph, IPointCommentaryNode {

  public CPointCommentaryNode(nint handle) : base(handle) {
  }

  public ref CUtlSymbolLarge PreCommands {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x1EE820D5A9BA18C4));
  }
  public ref CUtlSymbolLarge PostCommands {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x1EE820D52B9BBDED));
  }
  public ref CUtlSymbolLarge ViewTarget {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x1EE820D57F25C3A9));
  }
  public ref CHandle<CBaseEntity> ViewTarget {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x1EE820D5367DC4F3));
  }
  public ref CHandle<CBaseEntity> ViewTargetAngles {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x1EE820D57036CBB3));
  }
  public ref CUtlSymbolLarge ViewPosition {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x1EE820D5F077F9E3));
  }
  public ref CHandle<CBaseEntity> ViewPositionMover {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x1EE820D596E47DAA));
  }
  public ref bool PreventMovement {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1EE820D50513BCD8));
  }
  public ref bool UnderCrosshair {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1EE820D53DF2740B));
  }
  public ref bool Unstoppable {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1EE820D532F081DA));
  }
  public IGameTime_t FinishedTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1EE820D5E2616940));
  }
  public ref Vector FinishOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1EE820D5343348F4));
  }
  public ref QAngle OriginalAngles {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x1EE820D53F12AD96));
  }
  public ref QAngle FinishAngles {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x1EE820D58F00F976));
  }
  public ref bool PreventChangesWhileMoving {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1EE820D532F652B1));
  }
  public ref bool Disabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1EE820D53A7C5965));
  }
  public ref Vector TeleportOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1EE820D52953C748));
  }
  public IGameTime_t AbortedPlaybackAt {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x1EE820D5A444B332));
  }
  public IEntityIOOutput OnCommentaryStarted {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1EE820D50D986100));
  }
  public IEntityIOOutput OnCommentaryStopped {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1EE820D5C05AD020));
  }

  public void CommentaryFileUpdated() {
    Schema.Update(_Handle, 0x1EE820D5996CE112);
  }
  public void ViewPositionUpdated() {
    Schema.Update(_Handle, 0x1EE820D50C900ACD);
  }
  public void ActiveUpdated() {
    Schema.Update(_Handle, 0x1EE820D58334208F);
  }
  public void StartTimeUpdated() {
    Schema.Update(_Handle, 0x1EE820D567FE9DC4);
  }
  public void StartTimeInCommentaryUpdated() {
    Schema.Update(_Handle, 0x1EE820D50E5851F2);
  }
  public void TitleUpdated() {
    Schema.Update(_Handle, 0x1EE820D53337D6B1);
  }
  public void SpeakersUpdated() {
    Schema.Update(_Handle, 0x1EE820D5874211AB);
  }
  public void NodeNumberUpdated() {
    Schema.Update(_Handle, 0x1EE820D57BCFC491);
  }
  public void NodeNumberMaxUpdated() {
    Schema.Update(_Handle, 0x1EE820D5BFDF2335);
  }
  public void ListenedToUpdated() {
    Schema.Update(_Handle, 0x1EE820D545A4FC32);
  }
}