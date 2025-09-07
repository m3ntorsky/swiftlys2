using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBasePlatTrain : CBaseToggle, IBasePlatTrain {

  public CBasePlatTrain(nint handle) : base(handle) {
  }

  public CBasePlatTrain(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge NoiseMoving {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x78773ABC415AB84B));
  }
  public ref CUtlSymbolLarge NoiseArrived {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x78773ABCD2CDE47A));
  }
  public ref float Volume {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x78773ABCE3962F2F));
  }
  public ref float TWidth {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x78773ABCADF5A64B));
  }
  public ref float TLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x78773ABCA72CEC99));
  }


}