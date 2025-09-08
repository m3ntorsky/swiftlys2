using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CGameSceneNode : SchemaClass, IGameSceneNode {

  public CGameSceneNode(nint handle) : base(handle) {
  }

  public ref CTransform NodeToWorld {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0xD9451D94E9EB4068));
  }
  public IEntityInstance Owner {
    get => new CEntityInstance(_Handle + Schema.GetOffset(0xD9451D9406B325DA));
  }
  public IGameSceneNode Parent {
    get => new CGameSceneNode(_Handle + Schema.GetOffset(0xD9451D94B89C7C3F));
  }
  public IGameSceneNode Child {
    get => new CGameSceneNode(_Handle + Schema.GetOffset(0xD9451D944A0B773F));
  }
  public IGameSceneNode NextSibling {
    get => new CGameSceneNode(_Handle + Schema.GetOffset(0xD9451D9440E828FC));
  }
  public ref Vector AbsOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD9451D94E8B4EAE5));
  }
  public ref QAngle AbsRotation {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0xD9451D94AE099497));
  }
  public ref float AbsScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD9451D9480BD51E5));
  }
  public ref short ParentAttachmentOrBone {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xD9451D943A5CD26B));
  }
  public ref bool DebugAbsOriginChanges {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD9451D94EE4CADE7));
  }
  public ref bool Dormant {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD9451D94F9373B5E));
  }
  public ref bool ForceParentToBeNetworked {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xD9451D945A4F37E7));
  }
  public ISchemaUntypedField DirtyHierarchy {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD9451D947012AE3E));
  }
  public ISchemaUntypedField DirtyBoneMergeInfo {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD9451D94C0CDCFD7));
  }
  public ISchemaUntypedField NetworkedPositionChanged {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD9451D94CE9CD1FD));
  }
  public ISchemaUntypedField NetworkedAnglesChanged {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD9451D944D31E168));
  }
  public ISchemaUntypedField NetworkedScaleChanged {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD9451D94FBE9F8E2));
  }
  public ISchemaUntypedField WillBeCallingPostDataUpdate {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD9451D94352742F3));
  }
  public ISchemaUntypedField BoneMergeFlex {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD9451D948B6BC852));
  }
  public ISchemaUntypedField LatchAbsOrigin {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD9451D94BB41CC11));
  }
  public ISchemaUntypedField DirtyBoneMergeBoneToRoot {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xD9451D9472001FC8));
  }
  public ref byte HierarchicalDepth {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xD9451D94B7064305));
  }
  public ref byte HierarchyType {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xD9451D941DDA2C7C));
  }
  public ref byte DoNotSetAnimTimeInInvalidatePhysicsCount {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0xD9451D94B7293951));
  }
  public ref float ZOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD9451D94BD4A8DF4));
  }
  public ref float ClientLocalScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD9451D94957885D3));
  }
  public ref Vector RenderOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD9451D94A46385A3));
  }

  public void ParentUpdated() {
    Schema.Update(_Handle, 0xD9451D949FD3A1B7);
  }
  public void OriginUpdated() {
    Schema.Update(_Handle, 0xD9451D94559D81AF);
  }
  public void RotationUpdated() {
    Schema.Update(_Handle, 0xD9451D945E8229ED);
  }
  public void ScaleUpdated() {
    Schema.Update(_Handle, 0xD9451D94B731A42F);
  }
  public void NameUpdated() {
    Schema.Update(_Handle, 0xD9451D944D8F5786);
  }
  public void HierarchyAttachNameUpdated() {
    Schema.Update(_Handle, 0xD9451D9463D5B4EE);
  }
}