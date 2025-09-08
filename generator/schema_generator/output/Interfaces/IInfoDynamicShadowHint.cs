using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IInfoDynamicShadowHint : IPointEntity {

  public ref bool Disabled { get; }
  
  public ref float Range { get; }
  
  public ref int Importance { get; }
  
  public ref int LightChoice { get; }
  
  public ref CHandle<CBaseEntity> Light { get; }
  
}