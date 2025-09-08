using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISosGroupActionSoundeventPrioritySchema : ISosGroupActionSchema {

  public ref CUtlString PriorityValue { get; }
  
  public ref CUtlString PriorityVolumeScalar { get; }
  
  public ref CUtlString PriorityContributeButDontRead { get; }
  
  public ref CUtlString PriorityReadButDontContribute { get; }
  
}