using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EntityRenderAttribute_t : SchemaClass, IEntityRenderAttribute_t {

  public EntityRenderAttribute_t(nint handle) : base(handle) {
  }



  public void IDUpdated() {
    Schema.Update(_Handle, 0xBC8CD39195066900);
  }
  public void ValuesUpdated() {
    Schema.Update(_Handle, 0xBC8CD391A2E804BB);
  }
}