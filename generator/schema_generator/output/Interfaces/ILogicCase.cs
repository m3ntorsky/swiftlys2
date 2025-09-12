using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ILogicCase : ILogicalEntity {

  
  public ISchemaUntypedField Case { get; }
  
  public ref int ShuffleCases { get; }
  
  public ref int LastShuffleCase { get; }
  
  public ISchemaFixedArray<byte> UchShuffleCaseMap { get; }
  
  public IEntityIOOutput OnCase { get; }
  
  public ISchemaUntypedField OnDefault { get; }
}