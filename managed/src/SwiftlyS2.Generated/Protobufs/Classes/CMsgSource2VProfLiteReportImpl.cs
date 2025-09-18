
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CMsgSource2VProfLiteReportImpl : TypedProtobuf<CMsgSource2VProfLiteReport>, CMsgSource2VProfLiteReport
{
  public CMsgSource2VProfLiteReportImpl(nint handle): base(handle)
  {
  }


  public CMsgSource2VProfLiteReportItem Total
  { get => new CMsgSource2VProfLiteReportItemImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "total")); }


  public IProtobufRepeatedFieldSubMessageType<CMsgSource2VProfLiteReportItem> Items
  { get => new ProtobufRepeatedFieldSubMessageType<CMsgSource2VProfLiteReportItem>(Accessor, "items"); }


  public uint DiscardedFrames
  { get => Accessor.GetUInt32("discarded_frames"); set => Accessor.SetUInt32("discarded_frames", value); }

}
