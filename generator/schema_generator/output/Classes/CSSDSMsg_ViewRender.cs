using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSSDSMsg_ViewRender : SchemaClass, ISSDSMsg_ViewRender {

  public CSSDSMsg_ViewRender(nint handle) : base(handle) {
  }

  public CSSDSMsg_ViewRender(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ISceneViewId_t ViewId {
    get => new SceneViewId_t(_Handle + Schema.GetOffset(0x2CD48EEEE976CB25));
  }
  public ref CUtlString ViewName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x2CD48EEEBA5BBDBB));
  }


}