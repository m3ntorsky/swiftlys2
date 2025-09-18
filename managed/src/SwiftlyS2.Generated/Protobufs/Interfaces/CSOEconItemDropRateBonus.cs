
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CSOEconItemDropRateBonus : ITypedProtobuf<CSOEconItemDropRateBonus>
{
  static CSOEconItemDropRateBonus ITypedProtobuf<CSOEconItemDropRateBonus>.Wrap(nint handle) => new CSOEconItemDropRateBonusImpl(handle);


  public uint AccountId { get; set; }


  public int ExpirationDate { get; set; }


  public float Bonus { get; set; }


  public uint BonusCount { get; set; }


  public ulong ItemId { get; set; }


  public uint DefIndex { get; set; }

}
