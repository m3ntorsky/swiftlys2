using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class sky3dparams_t : SchemaClass, Isky3dparams_t {

  public sky3dparams_t(nint handle) : base(handle) {
  }

  public sky3dparams_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref short Scale {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0x49687CC482971C71));
  }
  public ref Vector Origin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x49687CC4D97F9A4F));
  }
  public ref bool Clip3DSkyBoxNearToWorldFar {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x49687CC482943804));
  }
  public ref float Clip3DSkyBoxNearToWorldFarOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x49687CC49D6E9441));
  }
  public Ifogparams_t Fog {
    get => new fogparams_t(_Handle + Schema.GetOffset(0x49687CC4A1F3723F));
  }
  public ref WorldGroupId_t WorldGroupID {
    get => ref _Handle.AsRef<WorldGroupId_t>(Schema.GetOffset(0x49687CC49414E3F3));
  }

  public void ScaleUpdated() {
    Schema.Update(_Handle, 0x49687CC482971C71);
  }
  public void OriginUpdated() {
    Schema.Update(_Handle, 0x49687CC4D97F9A4F);
  }
  public void Clip3DSkyBoxNearToWorldFarUpdated() {
    Schema.Update(_Handle, 0x49687CC482943804);
  }
  public void Clip3DSkyBoxNearToWorldFarOffsetUpdated() {
    Schema.Update(_Handle, 0x49687CC49D6E9441);
  }
  public void FogUpdated() {
    Schema.Update(_Handle, 0x49687CC4A1F3723F);
  }
  public void WorldGroupIDUpdated() {
    Schema.Update(_Handle, 0x49687CC49414E3F3);
  }
}