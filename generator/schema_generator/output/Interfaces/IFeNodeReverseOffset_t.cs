using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFeNodeReverseOffset_t : ISchemaClass {

  
  public ref Vector Offset { get; }
  
  public ref ushort BoneCtrl { get; }
  
  public ref ushort TargetNode { get; }
}