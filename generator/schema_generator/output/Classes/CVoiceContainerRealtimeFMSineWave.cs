using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CVoiceContainerRealtimeFMSineWave : CVoiceContainerBase, IVoiceContainerRealtimeFMSineWave {

  public CVoiceContainerRealtimeFMSineWave(nint handle) : base(handle) {
  }

  public ref float CarrierFrequency {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3AB0D193041DC311));
  }
  public ref float ModulatorFrequency {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3AB0D193656A8FFE));
  }
  public ref float ModulatorAmount {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x3AB0D1939B320E5C));
  }


}