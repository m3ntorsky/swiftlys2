using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncElectrifiedVolume : IFuncBrush {

  
  public ref CUtlSymbolLarge EffectName { get; }
  
  public ref CUtlSymbolLarge EffectInterpenetrateName { get; }
  
  public ref CUtlSymbolLarge EffectZapName { get; }
  
  public ref CUtlSymbolLarge EffectSource { get; }
}