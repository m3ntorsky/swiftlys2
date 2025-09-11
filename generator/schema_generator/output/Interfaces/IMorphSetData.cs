using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMorphSetData : ISchemaClass {

  
  public ref int Width { get; }
  
  public ref int Height { get; }
  
  public ref CUtlVector<MorphBundleType_t> BundleTypes { get; }
  
// CUtlVector< CMorphData >
  public ref CUtlVector MorphDatas { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCTextureBase> TextureAtlas { get; }
  
// CUtlVector< CFlexDesc >
  public ref CUtlVector FlexDesc { get; }
  
// CUtlVector< CFlexController >
  public ref CUtlVector FlexControllers { get; }
  
// CUtlVector< CFlexRule >
  public ref CUtlVector FlexRules { get; }
}