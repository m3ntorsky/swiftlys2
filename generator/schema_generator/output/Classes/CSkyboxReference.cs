using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSkyboxReference : CBaseEntity, ISkyboxReference {

  public CSkyboxReference(nint handle) : base(handle) {
  }

  public ref uint WorldGroupId {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x98809790BECFAC7));
  }
  public ref CHandle<CSkyCamera> SkyCamera {
    get => ref _Handle.AsRef<CHandle<CSkyCamera>>(Schema.GetOffset(0x988097906BB5B33));
  }


}