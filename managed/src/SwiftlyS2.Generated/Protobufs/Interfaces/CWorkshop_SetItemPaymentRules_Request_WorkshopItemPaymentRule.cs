
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CWorkshop_SetItemPaymentRules_Request_WorkshopItemPaymentRule : ITypedProtobuf<CWorkshop_SetItemPaymentRules_Request_WorkshopItemPaymentRule>
{
  static CWorkshop_SetItemPaymentRules_Request_WorkshopItemPaymentRule ITypedProtobuf<CWorkshop_SetItemPaymentRules_Request_WorkshopItemPaymentRule>.Wrap(nint handle) => new CWorkshop_SetItemPaymentRules_Request_WorkshopItemPaymentRuleImpl(handle);


  public ulong WorkshopFileId { get; set; }


  public float RevenuePercentage { get; set; }


  public string RuleDescription { get; set; }


  public uint RuleType { get; set; }

}
