using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeSimdNodeBase_t : ISchemaClass {

  
  public ISchemaFixedArray<ushort> Node { get; }
  
  public ISchemaFixedArray<ushort> NodeX0 { get; }
  
  public ISchemaFixedArray<ushort> NodeX1 { get; }
  
  public ISchemaFixedArray<ushort> NodeY0 { get; }
  
  public ISchemaFixedArray<ushort> NodeY1 { get; }
  
  public ISchemaFixedArray<ushort> Dummy { get; }
  
  public IFourQuaternions Adjust { get; }
}