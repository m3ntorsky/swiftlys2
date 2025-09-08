using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMorphSetData : ISchemaClass {

  public ref int Width { get; }
  
  public ref int Height { get; }
  
  public ref CUtlVector<MorphBundleType_t> BundleTypes { get; }
  
  public ref CUtlVector MorphDatas { get; }
  
  public CStrongHandle<IInfoForResourceTypeCTextureBase> TextureAtlas { get; }
  
  public ref CUtlVector FlexDesc { get; }
  
  public ref CUtlVector FlexControllers { get; }
  
  public ref CUtlVector FlexRules { get; }
  
}