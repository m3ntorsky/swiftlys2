using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VMixOscDesc_t : SchemaClass, IVMixOscDesc_t {

  public VMixOscDesc_t(nint handle) : base(handle) {
  }

  public VMixOscDesc_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref VMixLFOShape_t OscType {
    get => ref _Handle.AsRef<VMixLFOShape_t>(Schema.GetOffset(0x414F0016106B4054));
  }
  public ref float Freq {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x414F00164E0B0897));
  }
  public ref float Phase {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x414F00163C22A9CA));
  }


}