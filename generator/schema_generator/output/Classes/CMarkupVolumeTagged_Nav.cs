using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMarkupVolumeTagged_Nav : CMarkupVolumeTagged, IMarkupVolumeTagged_Nav {

  public CMarkupVolumeTagged_Nav(nint handle) : base(handle) {
  }

  public CMarkupVolumeTagged_Nav(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref NavScopeFlags_t Scopes {
    get => ref _Handle.AsRef<NavScopeFlags_t>(Schema.GetOffset(0x3E97D28E9E6C8A44));
  }


}