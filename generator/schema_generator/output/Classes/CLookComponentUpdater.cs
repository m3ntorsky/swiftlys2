using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLookComponentUpdater : CAnimComponentUpdater, ILookComponentUpdater {

  public CLookComponentUpdater(nint handle) : base(handle) {
  }

  public CLookComponentUpdater(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IAnimParamHandle LookHeading {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xA3C6996DE7EA9C52));
  }
  public IAnimParamHandle LookHeadingNormalized {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xA3C6996D305E6B07));
  }
  public IAnimParamHandle LookHeadingVelocity {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xA3C6996DF9527FD9));
  }
  public IAnimParamHandle LookPitch {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xA3C6996D3D4C7812));
  }
  public IAnimParamHandle LookDistance {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xA3C6996DD4722447));
  }
  public IAnimParamHandle LookDirection {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xA3C6996DAF5526AD));
  }
  public IAnimParamHandle LookTarget {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xA3C6996D3361F745));
  }
  public IAnimParamHandle LookTargetWorldSpace {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0xA3C6996DD1AC545F));
  }
  public ref bool NetworkLookTarget {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA3C6996D39F2F527));
  }


}