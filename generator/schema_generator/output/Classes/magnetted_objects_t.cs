using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class magnetted_objects_t : SchemaClass, Imagnetted_objects_t {

  public magnetted_objects_t(nint handle) : base(handle) {
  }

  public CHandle<IBaseEntity> Entity {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x494D696825B27FD0));
  }


}