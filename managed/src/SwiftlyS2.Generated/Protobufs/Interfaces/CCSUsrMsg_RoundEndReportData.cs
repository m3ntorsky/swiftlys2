
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;
using SwiftlyS2.Shared.NetMessages;

public interface CCSUsrMsg_RoundEndReportData : ITypedProtobuf<CCSUsrMsg_RoundEndReportData>, INetMessage<CCSUsrMsg_RoundEndReportData>
{
  static int INetMessage<CCSUsrMsg_RoundEndReportData>.MessageId => 379;
  
  static string INetMessage<CCSUsrMsg_RoundEndReportData>.MessageName => "CCSUsrMsg_RoundEndReportData";

  static CCSUsrMsg_RoundEndReportData ITypedProtobuf<CCSUsrMsg_RoundEndReportData>.Wrap(nint handle) => new CCSUsrMsg_RoundEndReportDataImpl(handle);


  public CCSUsrMsg_RoundEndReportData_InitialConditions InitConditions { get; }


  public IProtobufRepeatedFieldSubMessageType<CCSUsrMsg_RoundEndReportData_RerEvent> AllRerEventData { get; }

}
