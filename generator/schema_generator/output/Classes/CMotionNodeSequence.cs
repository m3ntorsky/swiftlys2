using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMotionNodeSequence : CMotionNode, IMotionNodeSequence {

  public CMotionNodeSequence(nint handle) : base(handle) {
  }

  public ref CUtlVector Tags {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xA932DE59B46C8540));
  }
  public IHSequence Sequence {
    get => new HSequence(_Handle + Schema.GetOffset(0xA932DE59E0A0598E));
  }
  public ref float PlaybackSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA932DE59FA2B402D));
  }


}