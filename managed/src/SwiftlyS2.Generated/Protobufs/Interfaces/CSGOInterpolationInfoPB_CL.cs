
using SwiftlyS2.Core.ProtobufDefinitions;
using SwiftlyS2.Shared.Natives;
using SwiftlyS2.Shared.NetMessages;

namespace SwiftlyS2.Shared.ProtobufDefinitions;

public interface CSGOInterpolationInfoPB_CL : ITypedProtobuf<CSGOInterpolationInfoPB_CL>
{
  static CSGOInterpolationInfoPB_CL ITypedProtobuf<CSGOInterpolationInfoPB_CL>.Wrap(nint handle) => new CSGOInterpolationInfoPB_CLImpl(handle);


  public float Frac { get; set; }

}
