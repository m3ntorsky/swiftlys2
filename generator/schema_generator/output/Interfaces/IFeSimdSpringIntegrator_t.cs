using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeSimdSpringIntegrator_t : ISchemaClass {

  public ISchemaFixedArray<ushort[4]> Node { get; }
  
  public ref fltx4 SpringRestLength { get; }
  
  public ref fltx4 SpringConstant { get; }
  
  public ref fltx4 SpringDamping { get; }
  
  public ref fltx4 NodeWeight0 { get; }
  
}