using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmFrameSnapEvent : CNmEvent, INmFrameSnapEvent {

  public CNmFrameSnapEvent(nint handle) : base(handle) {
  }

  public ref NmFrameSnapEventMode_t FrameSnapMode {
    get => ref _Handle.AsRef<NmFrameSnapEventMode_t>(Schema.GetOffset(0x948CA66C6C68AC59));
  }


}