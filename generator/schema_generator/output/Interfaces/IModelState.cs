using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IModelState : ISchemaClass {

  public ref CStrongHandle<InfoForResourceTypeCModel> Model { get; }
  
  public ref CUtlSymbolLarge ModelName { get; }
  
  public ref bool ClientClothCreationSuppressed { get; }
  
  public ref ulong MeshGroupMask { get; }
  
  public ref CUtlVector<int> BodyGroupChoices { get; }
  
  public ref byte IdealMotionType { get; }
  
  public ref byte ForceLOD { get; }
  
  public ref byte ClothUpdateFlags { get; }
  
}