using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncInteractionLayerClip : IBaseModelEntity {

  public ref bool Disabled { get; }
  
  public ref CUtlSymbolLarge InteractsAs { get; }
  
  public ref CUtlSymbolLarge InteractsWith { get; }
  
}