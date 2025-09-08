using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IModelMeshBufferData_t : ISchemaClass {

  public ref int BlockIndex { get; }
  
  public ref uint ElementCount { get; }
  
  public ref uint ElementSizeInBytes { get; }
  
  public ref bool MeshoptCompressed { get; }
  
  public ref bool MeshoptIndexSequence { get; }
  
  public ref bool CompressedZSTD { get; }
  
  public ref bool CreateBufferSRV { get; }
  
  public ref bool CreateBufferUAV { get; }
  
  public ref bool CreateRawBuffer { get; }
  
  public ref bool CreatePooledBuffer { get; }
  
  public ref CUtlVector InputLayoutFields { get; }
  
}