using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class VMixPitchShiftDesc_t : SchemaClass, IVMixPitchShiftDesc_t {

  public VMixPitchShiftDesc_t(nint handle) : base(handle) {
  }

  public VMixPitchShiftDesc_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int GrainSampleCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE7EEA08D6AA1D059));
  }
  public ref float PitchShift {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE7EEA08DD8E35569));
  }
  public ref int Quality {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE7EEA08D60857B42));
  }
  public ref int ProcType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE7EEA08DB256235D));
  }


}