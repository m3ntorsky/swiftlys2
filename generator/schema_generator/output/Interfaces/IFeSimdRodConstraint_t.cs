using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeSimdRodConstraint_t : ISchemaClass {

  public ISchemaFixedArray<ushort[4]> Node { get; }
  
  public ref fltx4 F4MaxDist { get; }
  
  public ref fltx4 F4MinDist { get; }
  
  public ref fltx4 F4Weight0 { get; }
  
  public ref fltx4 F4RelaxationFactor { get; }
  
}