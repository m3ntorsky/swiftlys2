using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeBandBendLimit_t : ISchemaClass {

  public ref float DistMin { get; }
  
  public ref float DistMax { get; }
  
  public ISchemaFixedArray<ushort> Node { get; }
  
}