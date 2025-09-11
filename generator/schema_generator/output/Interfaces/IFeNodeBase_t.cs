using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeNodeBase_t : ISchemaClass {

  
  public ref ushort Node { get; }
  
  public ISchemaFixedArray<ushort> Dummy { get; }
  
  public ref ushort NodeX0 { get; }
  
  public ref ushort NodeX1 { get; }
  
  public ref ushort NodeY0 { get; }
  
  public ref ushort NodeY1 { get; }
  
  public ref QuaternionStorage Adjust { get; }
}