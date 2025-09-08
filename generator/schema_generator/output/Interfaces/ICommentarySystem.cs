using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICommentarySystem : ISchemaClass {

  public ref bool CommentaryConvarsChanging { get; }
  
  public ref bool CommentaryEnabledMidGame { get; }
  
  public IGameTime_t NextTeleportTime { get; }
  
  public ref int TeleportStage { get; }
  
  public ref bool CheatState { get; }
  
  public ref bool IsFirstSpawnGroupToLoad { get; }
  
  public CHandle<IPointCommentaryNode> CurrentNode { get; }
  
  public CHandle<IPointCommentaryNode> ActiveCommentaryNode { get; }
  
  public CHandle<IPointCommentaryNode> LastCommentaryNode { get; }
  
  public ref CUtlVector Nodes { get; }
  
}