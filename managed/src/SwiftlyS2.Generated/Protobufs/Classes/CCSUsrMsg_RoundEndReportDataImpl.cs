
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CCSUsrMsg_RoundEndReportDataImpl : NetMessage<CCSUsrMsg_RoundEndReportData>, CCSUsrMsg_RoundEndReportData
{
  public CCSUsrMsg_RoundEndReportDataImpl(nint handle): base(handle)
  {
  }


  public CCSUsrMsg_RoundEndReportData_InitialConditions InitConditions
  { get => new CCSUsrMsg_RoundEndReportData_InitialConditionsImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "init_conditions")); }


  public IProtobufRepeatedFieldSubMessageType<CCSUsrMsg_RoundEndReportData_RerEvent> AllRerEventData
  { get => new ProtobufRepeatedFieldSubMessageType<CCSUsrMsg_RoundEndReportData_RerEvent>(Accessor, "all_rer_event_data"); }

}
