using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeSpringIntegrator_t : ISchemaClass {

  
  public ISchemaFixedArray<ushort> Node { get; }
  
  public ref float SpringRestLength { get; }
  
  public ref float SpringConstant { get; }
  
  public ref float SpringDamping { get; }
  
  public ref float NodeWeight0 { get; }
}