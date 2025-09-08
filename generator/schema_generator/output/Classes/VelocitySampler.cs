using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VelocitySampler : SchemaClass, IVelocitySampler {

  public VelocitySampler(nint handle) : base(handle) {
  }

  public ref Vector PrevSample {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x5547216E1BCE7EF2));
  }
  public IGameTime_t PrevSampleTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x5547216E0D491EE7));
  }
  public ref float IdealSampleRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5547216EF1562586));
  }


}