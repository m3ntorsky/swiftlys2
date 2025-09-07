using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSpotlightEnd : CBaseModelEntity, ISpotlightEnd {

  public CSpotlightEnd(nint handle) : base(handle) {
  }

  public CSpotlightEnd(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float LightScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x49085AA3E5A1295D));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x49085AA37C5B0533));
  }
  public ref Vector SpotlightDir {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x49085AA3EE68984A));
  }
  public ref Vector SpotlightOrg {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x49085AA34C84B367));
  }

  public void LightScaleUpdated() {
    Schema.Update(_Handle, 0x49085AA3E5A1295D);
  }
  public void RadiusUpdated() {
    Schema.Update(_Handle, 0x49085AA37C5B0533);
  }
}