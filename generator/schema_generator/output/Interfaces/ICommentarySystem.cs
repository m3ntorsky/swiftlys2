using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface ICommentarySystem : ISchemaClass {

  public ref bool CommentaryConvarsChanging { get; }
  
  public ref bool CommentaryEnabledMidGame { get; }
  
  public IGameTime_t NextTeleportTime { get; }
  
  public ref int TeleportStage { get; }
  
  public ref bool CheatState { get; }
  
  public ref bool IsFirstSpawnGroupToLoad { get; }
  
  public ref CHandle<CPointCommentaryNode> CurrentNode { get; }
  
  public ref CHandle<CPointCommentaryNode> ActiveCommentaryNode { get; }
  
  public ref CHandle<CPointCommentaryNode> LastCommentaryNode { get; }
  
  public ref CUtlVector<CHandle<CPointCommentaryNode>> Nodes { get; }
  
}