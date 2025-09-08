using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMorphRectData : ISchemaClass {

  public ref short XLeftDst { get; }
  
  public ref short YTopDst { get; }
  
  public ref float UWidthSrc { get; }
  
  public ref float VHeightSrc { get; }
  
  public ref CUtlVector BundleDatas { get; }
  
}