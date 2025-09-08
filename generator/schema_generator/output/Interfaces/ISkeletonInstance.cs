using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ISkeletonInstance : IGameSceneNode {

  public IModelState ModelState { get; }
  
  public ref bool IsAnimationEnabled { get; }
  
  public ref bool UseParentRenderBounds { get; }
  
  public ref bool DisableSolidCollisionsForHierarchy { get; }
  
  public ISchemaUntypedField DirtyMotionType { get; }
  
  public ISchemaUntypedField IsGeneratingLatchedParentSpaceState { get; }
  
  public ref CUtlStringToken MaterialGroup { get; }
  
  public ref byte HitboxSet { get; }
  
}