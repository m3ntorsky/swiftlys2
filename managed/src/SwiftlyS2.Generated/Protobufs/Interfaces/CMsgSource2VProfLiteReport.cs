
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgSource2VProfLiteReport : ITypedProtobuf<CMsgSource2VProfLiteReport>
{
  static CMsgSource2VProfLiteReport ITypedProtobuf<CMsgSource2VProfLiteReport>.Wrap(nint handle) => new CMsgSource2VProfLiteReportImpl(handle);


  public CMsgSource2VProfLiteReportItem Total { get; }


  public IProtobufRepeatedFieldSubMessageType<CMsgSource2VProfLiteReportItem> Items { get; }


  public uint DiscardedFrames { get; set; }

}
