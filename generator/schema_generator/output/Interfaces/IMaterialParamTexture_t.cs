using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMaterialParamTexture_t : IMaterialParam_t {

  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> Value { get; }
}