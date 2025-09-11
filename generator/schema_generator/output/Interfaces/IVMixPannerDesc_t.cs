using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVMixPannerDesc_t : ISchemaClass {

  
  public ref VMixPannerType_t Type { get; }
  
  public ref float Strength { get; }
}