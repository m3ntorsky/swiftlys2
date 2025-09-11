using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IWorldNodeOnDiskBufferData_t : ISchemaClass {

  
  public ref int ElementCount { get; }
  
  public ref int ElementSizeInBytes { get; }
  
// CUtlVector< RenderInputLayoutField_t >
  public ref CUtlVector InputLayoutFields { get; }
  
  public ref CUtlVector<byte> Data { get; }
}