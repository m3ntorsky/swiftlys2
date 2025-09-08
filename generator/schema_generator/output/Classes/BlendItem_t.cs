using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class BlendItem_t : SchemaClass, IBlendItem_t {

  public BlendItem_t(nint handle) : base(handle) {
  }

  public ref CUtlVector Tags {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x8FC3054B46C8540));
  }
  public IAnimUpdateNodeRef Child {
    get => new CAnimUpdateNodeRef(_Handle + Schema.GetOffset(0x8FC30544A0B773F));
  }
  public IHSequence Sequence {
    get => new HSequence(_Handle + Schema.GetOffset(0x8FC3054E0A0598E));
  }
  public ref Vector2D Pos {
    get => ref _Handle.AsRef<Vector2D>(Schema.GetOffset(0x8FC3054DE9CFC5D));
  }
  public ref float Duration {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x8FC3054BC5E3BAB));
  }
  public ref bool UseCustomDuration {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8FC3054F9BF05AB));
  }


}