
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CWorkshop_SetItemPaymentRules_Request_WorkshopDirectPaymentRule : ITypedProtobuf<CWorkshop_SetItemPaymentRules_Request_WorkshopDirectPaymentRule>
{
  static CWorkshop_SetItemPaymentRules_Request_WorkshopDirectPaymentRule ITypedProtobuf<CWorkshop_SetItemPaymentRules_Request_WorkshopDirectPaymentRule>.Wrap(nint handle) => new CWorkshop_SetItemPaymentRules_Request_WorkshopDirectPaymentRuleImpl(handle);


  public ulong WorkshopFileId { get; set; }


  public string RuleDescription { get; set; }

}
