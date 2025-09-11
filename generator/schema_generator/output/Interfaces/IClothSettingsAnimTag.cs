using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IClothSettingsAnimTag : IAnimTagBase {

  
  public ref float Stiffness { get; }
  
  public ref float EaseIn { get; }
  
  public ref float EaseOut { get; }
  
  public ref CUtlString VertexSet { get; }
}