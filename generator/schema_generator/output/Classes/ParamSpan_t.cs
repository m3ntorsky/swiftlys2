using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ParamSpan_t : SchemaClass, IParamSpan_t {

  public ParamSpan_t(nint handle) : base(handle) {
  }

  public ref CUtlVector Samples {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x5EE209D9364CA9DC));
  }
  public IAnimParamHandle Param {
    get => new CAnimParamHandle(_Handle + Schema.GetOffset(0x5EE209D9679286A4));
  }
  public ref AnimParamType_t ParamType {
    get => ref _Handle.AsRef<AnimParamType_t>(Schema.GetOffset(0x5EE209D9F05DFDD9));
  }
  public ref float StartCycle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5EE209D9ABB46051));
  }
  public ref float EndCycle {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5EE209D9176E8F62));
  }


}