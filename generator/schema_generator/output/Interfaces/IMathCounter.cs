using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMathCounter : ILogicalEntity {

  public ref float Min { get; }
  
  public ref float Max { get; }
  
  public ref bool HitMin { get; }
  
  public ref bool HitMax { get; }
  
  public ref bool Disabled { get; }
  
  public ISchemaUntypedField OutValue { get; }
  
  public ISchemaUntypedField OnGetValue { get; }
  
  public IEntityIOOutput OnHitMin { get; }
  
  public IEntityIOOutput OnHitMax { get; }
  
  public IEntityIOOutput OnChangedFromMin { get; }
  
  public IEntityIOOutput OnChangedFromMax { get; }
  
}