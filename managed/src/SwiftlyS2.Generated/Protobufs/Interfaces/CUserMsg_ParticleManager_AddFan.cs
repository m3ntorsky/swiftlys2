
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CUserMsg_ParticleManager_AddFan : ITypedProtobuf<CUserMsg_ParticleManager_AddFan>
{
  static CUserMsg_ParticleManager_AddFan ITypedProtobuf<CUserMsg_ParticleManager_AddFan>.Wrap(nint handle) => new CUserMsg_ParticleManager_AddFanImpl(handle);


  public bool Active { get; set; }


  public Vector BoundsMins { get; set; }


  public Vector BoundsMaxs { get; set; }


  public Vector FanOrigin { get; set; }


  public Vector FanOriginOffset { get; set; }


  public Vector FanDirection { get; set; }


  public float Force { get; set; }


  public string FanForceCurve { get; set; }


  public bool Falloff { get; set; }


  public bool PullTowardsPoint { get; set; }


  public float CurveMinDist { get; set; }


  public float CurveMaxDist { get; set; }

}
