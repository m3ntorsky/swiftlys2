using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IFootFixedData_t : ISchemaClass {

  
  public ref VectorAligned ToeOffset { get; }
  
  public ref VectorAligned HeelOffset { get; }
  
  public ref int TargetBoneIndex { get; }
  
  public ref int AnkleBoneIndex { get; }
  
  public ref int IKAnchorBoneIndex { get; }
  
  public ref int IkChainIndex { get; }
  
  public ref float MaxIKLength { get; }
  
  public ref int FootIndex { get; }
  
  public ref int TagIndex { get; }
  
  public ref float MaxRotationLeft { get; }
  
  public ref float MaxRotationRight { get; }
}