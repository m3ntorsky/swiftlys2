using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmTargetWarpEvent : CNmEvent, INmTargetWarpEvent {

  public CNmTargetWarpEvent(nint handle) : base(handle) {
  }

  public ref NmTargetWarpRule_t Rule {
    get => ref _Handle.AsRef<NmTargetWarpRule_t>(Schema.GetOffset(0x573F0894BA097173));
  }
  public ref NmTargetWarpAlgorithm_t Algorithm {
    get => ref _Handle.AsRef<NmTargetWarpAlgorithm_t>(Schema.GetOffset(0x573F0894265CAE8A));
  }


}