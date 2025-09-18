
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CMsgGCCstrike15_v2_ClientRedeemMissionReward : ITypedProtobuf<CMsgGCCstrike15_v2_ClientRedeemMissionReward>
{
  static CMsgGCCstrike15_v2_ClientRedeemMissionReward ITypedProtobuf<CMsgGCCstrike15_v2_ClientRedeemMissionReward>.Wrap(nint handle) => new CMsgGCCstrike15_v2_ClientRedeemMissionRewardImpl(handle);


  public uint CampaignId { get; set; }


  public uint RedeemId { get; set; }


  public uint RedeemableBalance { get; set; }


  public uint ExpectedCost { get; set; }


  public int BidControl { get; set; }

}
