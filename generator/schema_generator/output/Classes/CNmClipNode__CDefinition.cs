using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmClipNode__CDefinition : CNmClipReferenceNode::CDefinition, INmClipNode__CDefinition {

  public CNmClipNode__CDefinition(nint handle) : base(handle) {
  }

  public CNmClipNode__CDefinition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short PlayInReverseValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x9BA44A131BE16D82));
  }
  public ref short ResetTimeValueNodeIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x9BA44A13698930E1));
  }
  public ref float SpeedMultiplier {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9BA44A135D5B304D));
  }
  public ref int StartSyncEventOffset {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9BA44A138A6F2A97));
  }
  public ref bool SampleRootMotion {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9BA44A139443A5E9));
  }
  public ref bool AllowLooping {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9BA44A13FEB26D98));
  }
  public ref short DataSlotIdx {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x9BA44A13B1C15B68));
  }


}