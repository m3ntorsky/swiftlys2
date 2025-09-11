using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IModelConfigList : ISchemaClass {

  
  public ref bool HideMaterialGroupInTools { get; }
  
  public ref bool HideRenderColorInTools { get; }
  
  public ref CUtlVector<PointerTo<CModelConfig>> Configs { get; }
}