using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMarkupVolumeWithRef : CMarkupVolumeTagged, IMarkupVolumeWithRef {

  public CMarkupVolumeWithRef(nint handle) : base(handle) {
  }

  public CMarkupVolumeWithRef(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool UseRef {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x12AA97857F572B29));
  }
  public ref Vector RefPosEntitySpace {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x12AA978532BBDFAB));
  }
  public ref Vector RefPosWorldSpace {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x12AA97856139C236));
  }
  public ref float RefDot {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x12AA9785584DB957));
  }


}