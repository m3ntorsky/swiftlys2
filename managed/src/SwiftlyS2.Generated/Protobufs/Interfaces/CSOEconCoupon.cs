
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CSOEconCoupon : ITypedProtobuf<CSOEconCoupon>
{
  static CSOEconCoupon ITypedProtobuf<CSOEconCoupon>.Wrap(nint handle) => new CSOEconCouponImpl(handle);


  public uint Entryid { get; set; }


  public uint Defidx { get; set; }


  public int ExpirationDate { get; set; }

}
