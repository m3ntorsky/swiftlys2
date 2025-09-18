
using SwiftlyS2.Core.Natives;
using SwiftlyS2.Core.NetMessages;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;
using SwiftlyS2.Shared.ProtobufDefinitions;

namespace SwiftlyS2.Core.ProtobufDefinitions;

internal class CCLCMsg_DiagnosticImpl : NetMessage<CCLCMsg_Diagnostic>, CCLCMsg_Diagnostic
{
  public CCLCMsg_DiagnosticImpl(nint handle): base(handle)
  {
  }


  public CMsgSource2SystemSpecs SystemSpecs
  { get => new CMsgSource2SystemSpecsImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "system_specs")); }


  public CMsgSource2VProfLiteReport VprofReport
  { get => new CMsgSource2VProfLiteReportImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "vprof_report")); }


  public CMsgSource2NetworkFlowQuality DownstreamFlow
  { get => new CMsgSource2NetworkFlowQualityImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "downstream_flow")); }


  public CMsgSource2NetworkFlowQuality UpstreamFlow
  { get => new CMsgSource2NetworkFlowQualityImpl(NativeNetMessages.GetNestedMessage(GetHandle(), "upstream_flow")); }

}
