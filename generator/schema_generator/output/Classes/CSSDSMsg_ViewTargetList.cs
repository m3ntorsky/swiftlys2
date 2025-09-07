using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSSDSMsg_ViewTargetList : SchemaClass, ISSDSMsg_ViewTargetList {

  public CSSDSMsg_ViewTargetList(nint handle) : base(handle) {
  }

  public CSSDSMsg_ViewTargetList(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISceneViewId_t ViewId {
    get => new SceneViewId_t(_Handle + Schema.GetOffset(0xD53B3083E976CB25));
  }
  public ref CUtlString ViewName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xD53B3083BA5BBDBB));
  }
  public ref CUtlVector< CSSDSMsg_ViewTarget > Targets {
    get => ref _Handle.AsRef<CUtlVector< CSSDSMsg_ViewTarget >>(Schema.GetOffset(0xD53B30832FF8E661));
  }


}