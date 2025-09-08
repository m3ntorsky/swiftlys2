using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMathRemap : ILogicalEntity {

  public ref float InMin { get; }
  
  public ref float InMax { get; }
  
  public ref float Out1 { get; }
  
  public ref float Out2 { get; }
  
  public ref float OldInValue { get; }
  
  public ref bool Enabled { get; }
  
  public ISchemaUntypedField OutValue { get; }
  
  public IEntityIOOutput OnRoseAboveMin { get; }
  
  public IEntityIOOutput OnRoseAboveMax { get; }
  
  public IEntityIOOutput OnFellBelowMin { get; }
  
  public IEntityIOOutput OnFellBelowMax { get; }
  
}