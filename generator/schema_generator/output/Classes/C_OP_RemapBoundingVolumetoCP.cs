using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapBoundingVolumetoCP : CParticleFunctionPreEmission, IC_OP_RemapBoundingVolumetoCP {

  public C_OP_RemapBoundingVolumetoCP(nint handle) : base(handle) {
  }

  public ref int OutControlPointNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBFFF451ED021D73F));
  }
  public ref float InputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBFFF451EE88A0D0F));
  }
  public ref float InputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBFFF451ED6766901));
  }
  public ref float OutputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBFFF451E5F8D7716));
  }
  public ref float OutputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBFFF451E51A0E8C4));
  }


}