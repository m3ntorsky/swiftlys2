using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRopeKeyframe : CBaseModelEntity, IRopeKeyframe {

  public CRopeKeyframe(nint handle) : base(handle) {
  }

  public CRopeKeyframe(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ushort RopeFlags {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x76EE758E2EF994F4));
  }
  public ref CUtlSymbolLarge NextLinkName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x76EE758EFD59AE1A));
  }
  public ref short Slack {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x76EE758E84ECDEA7));
  }
  public ref float Width {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x76EE758E2FD9239F));
  }
  public ref float TextureScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x76EE758EA14A014E));
  }
  public ref byte Segments {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x76EE758E4878E17B));
  }
  public ref bool ConstrainBetweenEndpoints {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x76EE758E05033E3C));
  }
  public ref CUtlSymbolLarge StrRopeMaterialModel {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x76EE758E7A58C07A));
  }
  public ref CStrongHandle< InfoForResourceTypeIMaterial2 > RopeMaterialModelIndex {
    get => ref _Handle.AsRef<CStrongHandle< InfoForResourceTypeIMaterial2 >>(Schema.GetOffset(0x76EE758E831DE452));
  }
  public ref byte Subdiv {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x76EE758E785F10D8));
  }
  public ref byte ChangeCount {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x76EE758E167C12A8));
  }
  public ref short RopeLength {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x76EE758EC27FC78D));
  }
  public ref byte LockedPoints {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x76EE758ECE6446D4));
  }
  public ref bool CreatedFromMapFile {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x76EE758EB4684909));
  }
  public ref float ScrollSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x76EE758E448C9F71));
  }
  public ref bool StartPointValid {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x76EE758E949209D3));
  }
  public ref bool EndPointValid {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x76EE758E938F0CDE));
  }
  public ref CHandle< CBaseEntity > StartPoint {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x76EE758ECCE549A9));
  }
  public ref CHandle< CBaseEntity > EndPoint {
    get => ref _Handle.AsRef<CHandle< CBaseEntity >>(Schema.GetOffset(0x76EE758E5E8C8D3A));
  }
  public IAttachmentHandle_t StartAttachment {
    get => new AttachmentHandle_t(_Handle + Schema.GetOffset(0x76EE758E1022E6F5));
  }
  public IAttachmentHandle_t EndAttachment {
    get => new AttachmentHandle_t(_Handle + Schema.GetOffset(0x76EE758ED537713C));
  }

  public void RopeFlagsUpdated() {
    Schema.Update(_Handle, 0x76EE758E2EF994F4);
  }
  public void SlackUpdated() {
    Schema.Update(_Handle, 0x76EE758E84ECDEA7);
  }
  public void WidthUpdated() {
    Schema.Update(_Handle, 0x76EE758E2FD9239F);
  }
  public void TextureScaleUpdated() {
    Schema.Update(_Handle, 0x76EE758EA14A014E);
  }
  public void SegmentsUpdated() {
    Schema.Update(_Handle, 0x76EE758E4878E17B);
  }
  public void ConstrainBetweenEndpointsUpdated() {
    Schema.Update(_Handle, 0x76EE758E05033E3C);
  }
  public void RopeMaterialModelIndexUpdated() {
    Schema.Update(_Handle, 0x76EE758E831DE452);
  }
  public void SubdivUpdated() {
    Schema.Update(_Handle, 0x76EE758E785F10D8);
  }
  public void ChangeCountUpdated() {
    Schema.Update(_Handle, 0x76EE758E167C12A8);
  }
  public void RopeLengthUpdated() {
    Schema.Update(_Handle, 0x76EE758EC27FC78D);
  }
  public void LockedPointsUpdated() {
    Schema.Update(_Handle, 0x76EE758ECE6446D4);
  }
  public void ScrollSpeedUpdated() {
    Schema.Update(_Handle, 0x76EE758E448C9F71);
  }
  public void StartPointUpdated() {
    Schema.Update(_Handle, 0x76EE758ECCE549A9);
  }
  public void EndPointUpdated() {
    Schema.Update(_Handle, 0x76EE758E5E8C8D3A);
  }
  public void StartAttachmentUpdated() {
    Schema.Update(_Handle, 0x76EE758E1022E6F5);
  }
  public void EndAttachmentUpdated() {
    Schema.Update(_Handle, 0x76EE758ED537713C);
  }
}