using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeNodeIntegrator_t : SchemaClass, IFeNodeIntegrator_t {

  public FeNodeIntegrator_t(nint handle) : base(handle) {
  }

  public FeNodeIntegrator_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float PointDamping {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x64217E4215738003));
  }
  public ref float AnimationForceAttraction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x64217E423D09A7B3));
  }
  public ref float AnimationVertexAttraction {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x64217E424E9EA4DC));
  }
  public ref float Gravity {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x64217E4289B3B847));
  }


}