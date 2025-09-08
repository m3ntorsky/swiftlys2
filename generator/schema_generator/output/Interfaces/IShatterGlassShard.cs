using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IShatterGlassShard : ISchemaClass {

  public ref uint ShardHandle { get; }
  
  public ref CUtlVector<Vector2D> PanelVertices { get; }
  
  public ref Vector2D LocalPanelSpaceOrigin { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCModel> Model { get; }
  
  public ref CHandle<CShatterGlassShardPhysics> PhysicsEntity { get; }
  
  public ref CHandle<CFuncShatterglass> ParentPanel { get; }
  
  public ref uint ParentShard { get; }
  
  public ref ShatterGlassStressType ShatterStressType { get; }
  
  public ref Vector StressVelocity { get; }
  
  public ref bool CreatedModel { get; }
  
  public ref float LongestEdge { get; }
  
  public ref float ShortestEdge { get; }
  
  public ref float LongestAcross { get; }
  
  public ref float ShortestAcross { get; }
  
  public ref float SumOfAllEdges { get; }
  
  public ref float Area { get; }
  
  public ref OnFrame OnFrameEdge { get; }
  
  public ref int SubShardGeneration { get; }
  
  public ref Vector2D AverageVertPosition { get; }
  
  public ref bool AverageVertPositionIsValid { get; }
  
  public ref Vector2D PanelSpaceStressPositionA { get; }
  
  public ref Vector2D PanelSpaceStressPositionB { get; }
  
  public ref bool StressPositionAIsValid { get; }
  
  public ref bool StressPositionBIsValid { get; }
  
  public ref bool FlaggedForRemoval { get; }
  
  public IGameTime_t PhysicsEntitySpawnedAtTime { get; }
  
  public ref CHandle<CBaseEntity> EntityHittingMe { get; }
  
  public ref CUtlVector<uint> Neighbors { get; }
  
}