using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class BaseSceneObjectOverride_t : SchemaClass, IBaseSceneObjectOverride_t {

  public BaseSceneObjectOverride_t(nint handle) : base(handle) {
  }

  public ref uint SceneObjectIndex {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0xDC119FF44026A3B8));
  }


}