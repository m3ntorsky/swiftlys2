using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VMixDynamicsBand_t : SchemaClass, IVMixDynamicsBand_t {

  public VMixDynamicsBand_t(nint handle) : base(handle) {
  }

  public ref float FldbGainInput {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC3A63113E9F143B6));
  }
  public ref float FldbGainOutput {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC3A63113FC3C16D3));
  }
  public ref float FldbThresholdBelow {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC3A6311311693729));
  }
  public ref float FldbThresholdAbove {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC3A631134516A525));
  }
  public ref float RatioBelow {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC3A63113560F0E57));
  }
  public ref float RatioAbove {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC3A631139E701FCB));
  }
  public ref float AttackTimeMS {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC3A63113D4A28216));
  }
  public ref float ReleaseTimeMS {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC3A63113EBB62791));
  }
  public ref bool Enable {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3A6311313C00D2E));
  }
  public ref bool Solo {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC3A63113CF623EAA));
  }


}