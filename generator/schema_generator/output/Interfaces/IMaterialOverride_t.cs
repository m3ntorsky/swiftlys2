using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMaterialOverride_t : IBaseSceneObjectOverride_t {

  public ref uint SubSceneObject { get; }
  
  public ref uint DrawCallIndex { get; }
  
  public ref CStrongHandle<InfoForResourceTypeIMaterial2> Material { get; }
  
  public ref Vector LinearTintColor { get; }
  
}