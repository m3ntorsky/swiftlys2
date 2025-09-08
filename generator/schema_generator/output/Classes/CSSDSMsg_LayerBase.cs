using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSSDSMsg_LayerBase : SchemaClass, ISSDSMsg_LayerBase {

  public CSSDSMsg_LayerBase(nint handle) : base(handle) {
  }

  public ISceneViewId_t ViewId {
    get => new SceneViewId_t(_Handle + Schema.GetOffset(0x9F18C5E5E976CB25));
  }
  public ref CUtlString ViewName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x9F18C5E5BA5BBDBB));
  }
  public ref ulong LayerId {
    get => ref _Handle.AsRef<ulong>(Schema.GetOffset(0x9F18C5E531A19D87));
  }
  public ref CUtlString LayerName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x9F18C5E55A7163B5));
  }
  public ref CUtlString DisplayText {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x9F18C5E5F59D71EE));
  }


}