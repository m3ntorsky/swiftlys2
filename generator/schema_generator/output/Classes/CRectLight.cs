using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRectLight : CBarnLight, IRectLight {

  public CRectLight(nint handle) : base(handle) {
  }

  public CRectLight(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref bool ShowLight {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF5C5D1F4D67BC720));
  }

  public void ShowLightUpdated() {
    Schema.Update(_Handle, 0xF5C5D1F4D67BC720);
  }
}