using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class MaterialParamTexture_t : MaterialParam_t, IMaterialParamTexture_t {

  public MaterialParamTexture_t(nint handle) : base(handle) {
  }

  public CStrongHandle<IInfoForResourceTypeCTextureBase> Value {
    get => new CStrongHandle<InfoForResourceTypeCTextureBase>(_Handle + Schema.GetOffset(0x17803E3B7F437844));
  }


}