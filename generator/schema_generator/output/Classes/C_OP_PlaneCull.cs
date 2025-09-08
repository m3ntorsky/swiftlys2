using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_PlaneCull : CParticleFunctionOperator, IC_OP_PlaneCull {

  public C_OP_PlaneCull(nint handle) : base(handle) {
  }

  public ref int PlaneControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x352AAF45E621E9BC));
  }
  public ref Vector PlaneDirection {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x352AAF45B00A585A));
  }
  public ref bool LocalSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x352AAF4562418E6E));
  }
  public ref float PlaneOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x352AAF45D394676C));
  }


}