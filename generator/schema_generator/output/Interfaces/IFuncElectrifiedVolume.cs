using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFuncElectrifiedVolume : IFuncBrush {

  
  public ISchemaUntypedField EffectName { get; }
  
  public ISchemaUntypedField EffectInterpenetrateName { get; }
  
  public ISchemaUntypedField EffectZapName { get; }
  
  public ISchemaUntypedField EffectSource { get; }
}