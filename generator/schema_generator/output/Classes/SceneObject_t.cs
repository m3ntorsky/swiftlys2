using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class SceneObject_t : SchemaClass, ISceneObject_t {

  public SceneObject_t(nint handle) : base(handle) {
  }

  public ref uint ObjectID {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xD71D99937D1B0793));
  }
  public ISchemaFixedArray<Vector4D> Transform {
    get => new SchemaFixedArray<Vector4D>(_Handle, 0xD71D9993EAAE256F, 3, 16, 4);
  }
  public ref float FadeStartDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD71D99931AE7B71C));
  }
  public ref float FadeEndDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xD71D999328802B3D));
  }
  public ref Vector4D TintColor {
    get => ref _Handle.AsRef<Vector4D>(Schema.GetOffset(0xD71D999350AFF21F));
  }
  public ref CUtlString Skin {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xD71D9993F1469658));
  }
  public ref ObjectTypeFlags_t ObjectTypeFlags {
    get => ref _Handle.AsRef<ObjectTypeFlags_t>(Schema.GetOffset(0xD71D9993D9506A69));
  }
  public ref Vector LightingOrigin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xD71D9993384A57CF));
  }
  public ref short OverlayRenderOrder {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xD71D99935F955EED));
  }
  public ref short LODOverride {
    get => ref _Handle.AsRef<short>(Schema.GetOffset(0xD71D999301DBC0FC));
  }
  public ref int CubeMapPrecomputedHandshake {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD71D99939B8535E1));
  }
  public ref int LightProbeVolumePrecomputedHandshake {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xD71D9993C6233022));
  }
  public CStrongHandle<IInfoForResourceTypeCModel> RenderableModel {
    get => new CStrongHandle<InfoForResourceTypeCModel>(_Handle + Schema.GetOffset(0xD71D99932AEEFA82));
  }
  public CStrongHandle<IInfoForResourceTypeCRenderMesh> Renderable {
    get => new CStrongHandle<InfoForResourceTypeCRenderMesh>(_Handle + Schema.GetOffset(0xD71D9993972EF84D));
  }


}