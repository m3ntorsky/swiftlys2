
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CCSPredictionEvent_DamageTag : ITypedProtobuf<CCSPredictionEvent_DamageTag>
{
  static CCSPredictionEvent_DamageTag ITypedProtobuf<CCSPredictionEvent_DamageTag>.Wrap(nint handle) => new CCSPredictionEvent_DamageTagImpl(handle);


  public float FlinchModSmall { get; set; }


  public float FlinchModLarge { get; set; }


  public float FriendlyFireDamageReductionRatio { get; set; }

}
