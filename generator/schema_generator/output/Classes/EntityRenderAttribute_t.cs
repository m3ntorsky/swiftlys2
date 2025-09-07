using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EntityRenderAttribute_t : SchemaClass, IEntityRenderAttribute_t {

  public EntityRenderAttribute_t(nint handle) : base(handle) {
  }

  public EntityRenderAttribute_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlStringToken ID {
    get => ref _Handle.AsRef<CUtlStringToken>(Schema.GetOffset(0xBC8CD39195066900));
  }
  public ref Vector4D Values {
    get => ref _Handle.AsRef<Vector4D>(Schema.GetOffset(0xBC8CD391A2E804BB));
  }

  public void IDUpdated() {
    Schema.Update(_Handle, 0xBC8CD39195066900);
  }
  public void ValuesUpdated() {
    Schema.Update(_Handle, 0xBC8CD391A2E804BB);
  }
}