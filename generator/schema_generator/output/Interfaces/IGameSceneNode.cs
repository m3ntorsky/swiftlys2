using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IGameSceneNode : ISchemaClass {

  public ref CTransform NodeToWorld { get; }
  
  public IEntityInstance Owner { get; }
  
  public IGameSceneNode Parent { get; }
  
  public IGameSceneNode Child { get; }
  
  public IGameSceneNode NextSibling { get; }
  
  public IGameSceneNodeHandle Parent { get; }
  
  public INetworkOriginCellCoordQuantizedVector Origin { get; }
  
  public ref QAngle Rotation { get; }
  
  public ref float Scale { get; }
  
  public ref Vector AbsOrigin { get; }
  
  public ref QAngle AbsRotation { get; }
  
  public ref float AbsScale { get; }
  
  public ref short ParentAttachmentOrBone { get; }
  
  public ref bool DebugAbsOriginChanges { get; }
  
  public ref bool Dormant { get; }
  
  public ref bool ForceParentToBeNetworked { get; }
  
  public ISchemaUntypedField DirtyHierarchy { get; }
  
  public ISchemaUntypedField DirtyBoneMergeInfo { get; }
  
  public ISchemaUntypedField NetworkedPositionChanged { get; }
  
  public ISchemaUntypedField NetworkedAnglesChanged { get; }
  
  public ISchemaUntypedField NetworkedScaleChanged { get; }
  
  public ISchemaUntypedField WillBeCallingPostDataUpdate { get; }
  
  public ISchemaUntypedField BoneMergeFlex { get; }
  
  public ISchemaUntypedField LatchAbsOrigin { get; }
  
  public ISchemaUntypedField DirtyBoneMergeBoneToRoot { get; }
  
  public ref byte HierarchicalDepth { get; }
  
  public ref byte HierarchyType { get; }
  
  public ref byte DoNotSetAnimTimeInInvalidatePhysicsCount { get; }
  
  public ref CUtlStringToken Name { get; }
  
  public ref CUtlStringToken HierarchyAttachName { get; }
  
  public ref float ZOffset { get; }
  
  public ref float ClientLocalScale { get; }
  
  public ref Vector RenderOrigin { get; }
  
}