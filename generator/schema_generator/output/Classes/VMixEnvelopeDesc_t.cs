using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VMixEnvelopeDesc_t : SchemaClass, IVMixEnvelopeDesc_t {

  public VMixEnvelopeDesc_t(nint handle) : base(handle) {
  }

  public ref float AttackTimeMS {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEF93602BD4A28216));
  }
  public ref float HoldTimeMS {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEF93602B028BA44F));
  }
  public ref float ReleaseTimeMS {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xEF93602BEBB62791));
  }


}