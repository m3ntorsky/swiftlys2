using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeSimdRodConstraintAnim_t : ISchemaClass {

  public ISchemaFixedArray<ushort[4]> Node { get; }
  
  public ref fltx4 F4Weight0 { get; }
  
  public ref fltx4 F4RelaxationFactor { get; }
  
}