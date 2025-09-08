using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface INmTarget : ISchemaClass {

  public ref CTransform Transform { get; }
  
  public ref CGlobalSymbol BoneID { get; }
  
  public ref bool IsBoneTarget { get; }
  
  public ref bool IsUsingBoneSpaceOffsets { get; }
  
  public ref bool HasOffsets { get; }
  
  public ref bool IsSet { get; }
  
}