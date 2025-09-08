using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCommentarySystem : SchemaClass, ICommentarySystem {

  public CCommentarySystem(nint handle) : base(handle) {
  }

  public ref bool CommentaryConvarsChanging {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x87CBBE6A7FB57A2D));
  }
  public ref bool CommentaryEnabledMidGame {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x87CBBE6A45558B4F));
  }
  public IGameTime_t NextTeleportTime {
    get => new GameTime_t(_Handle + Schema.GetOffset(0x87CBBE6A92701808));
  }
  public ref int TeleportStage {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x87CBBE6A75C25D8B));
  }
  public ref bool CheatState {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x87CBBE6AA9DE3831));
  }
  public ref bool IsFirstSpawnGroupToLoad {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x87CBBE6A1BDE1032));
  }
  public CHandle<IPointCommentaryNode> CurrentNode {
    get => new CHandle<CPointCommentaryNode>(_Handle + Schema.GetOffset(0x87CBBE6A5C1029D4));
  }
  public CHandle<IPointCommentaryNode> ActiveCommentaryNode {
    get => new CHandle<CPointCommentaryNode>(_Handle + Schema.GetOffset(0x87CBBE6AEA08BE3C));
  }
  public CHandle<IPointCommentaryNode> LastCommentaryNode {
    get => new CHandle<CPointCommentaryNode>(_Handle + Schema.GetOffset(0x87CBBE6A33A2318A));
  }
  public ref CUtlVector Nodes {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x87CBBE6A5CCA593A));
  }


}