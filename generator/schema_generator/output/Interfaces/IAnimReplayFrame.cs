using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IAnimReplayFrame : ISchemaClass {

  public ref CUtlVector<CUtlBinaryBlock> InputDataBlocks { get; }
  
  public ref CUtlBinaryBlock InstanceData { get; }
  
  public ref CTransform StartingLocalToWorldTransform { get; }
  
  public ref CTransform LocalToWorldTransform { get; }
  
  public ref float TimeStamp { get; }
  
}