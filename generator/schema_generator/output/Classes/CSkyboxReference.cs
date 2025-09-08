using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSkyboxReference : CBaseEntity, ISkyboxReference {

  public CSkyboxReference(nint handle) : base(handle) {
  }

  public ref WorldGroupId_t WorldGroupId {
    get => ref _Handle.AsRef<WorldGroupId_t>(Schema.GetOffset(0x98809790BECFAC7));
  }
  public CHandle<ISkyCamera> SkyCamera {
    get => new CHandle<CSkyCamera>(_Handle + Schema.GetOffset(0x988097906BB5B33));
  }


}