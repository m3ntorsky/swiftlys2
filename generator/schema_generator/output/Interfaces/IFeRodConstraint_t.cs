using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeRodConstraint_t : ISchemaClass {

  
  public ISchemaFixedArray<ushort> Node { get; }
  
  public ref float MaxDist { get; }
  
  public ref float MinDist { get; }
  
  public ref float Weight0 { get; }
  
  public ref float RelaxationFactor { get; }
}