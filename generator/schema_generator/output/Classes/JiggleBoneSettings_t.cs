using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class JiggleBoneSettings_t : SchemaClass, IJiggleBoneSettings_t {

  public JiggleBoneSettings_t(nint handle) : base(handle) {
  }

  public JiggleBoneSettings_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int BoneIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xBEFF05219F407B79));
  }
  public ref float SpringStrength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBEFF0521595D254F));
  }
  public ref float MaxTimeStep {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBEFF052177D1E0C4));
  }
  public ref float Damping {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBEFF0521AAC624EB));
  }
  public ref Vector BoundsMaxLS {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xBEFF0521ABADA913));
  }
  public ref Vector BoundsMinLS {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xBEFF0521FF607855));
  }
  public ref JiggleBoneSimSpace SimSpace {
    get => ref _Handle.AsRef<JiggleBoneSimSpace>(Schema.GetOffset(0xBEFF052186872533));
  }


}