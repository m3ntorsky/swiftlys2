using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IDecalGroupOption_t : ISchemaClass {

  public CStrongHandle<Iopyable<InfoForResourceTypeIMaterial2> Material { get; }
  
  public ref CGlobalSymbol SequenceName { get; }
  
  public ref float Probability { get; }
  
  public ref bool EnableAngleBetweenNormalAndGravityRange { get; }
  
  public ref float MinAngleBetweenNormalAndGravity { get; }
  
  public ref float MaxAngleBetweenNormalAndGravity { get; }
  
}