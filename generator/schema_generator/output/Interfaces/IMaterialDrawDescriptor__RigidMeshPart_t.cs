using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IMaterialDrawDescriptor__RigidMeshPart_t : ISchemaClass {

  
  public ref ushort RigidBLASIndex { get; }
  
  public ref short BoneIndex { get; }
  
  public ref uint StartIndexOffset { get; }
  
  public ref uint PrimitiveCount { get; }
}