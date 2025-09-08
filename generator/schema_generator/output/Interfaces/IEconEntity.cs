using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IEconEntity : IBaseFlex {

  public IAttributeContainer AttributeManager { get; }
  
  public ref uint OriginalOwnerXuidLow { get; }
  
  public ref uint OriginalOwnerXuidHigh { get; }
  
  public ref int FallbackPaintKit { get; }
  
  public ref int FallbackSeed { get; }
  
  public ref float FallbackWear { get; }
  
  public ref int FallbackStatTrak { get; }
  
  public ref CHandle<CBaseEntity> OldProvidee { get; }
  
  public ref int OldOwnerClass { get; }
  
}