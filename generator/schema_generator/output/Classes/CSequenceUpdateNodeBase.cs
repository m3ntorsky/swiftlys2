using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSequenceUpdateNodeBase : CLeafUpdateNode, ISequenceUpdateNodeBase {

  public CSequenceUpdateNodeBase(nint handle) : base(handle) {
  }

  public CSequenceUpdateNodeBase(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float PlaybackSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x6FCA4DDB1AFA7387));
  }
  public ref bool Loop {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6FCA4DDBC668A4CB));
  }


}