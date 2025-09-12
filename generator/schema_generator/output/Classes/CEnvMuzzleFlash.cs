using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnvMuzzleFlash : CPointEntity, IEnvMuzzleFlash {

  public CEnvMuzzleFlash(nint handle) : base(handle) {
  }

  public ref float Scale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2EBDF9DEB731A42F));
  }
  public ISchemaUntypedField ParentAttachment {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x2EBDF9DE0061F288));
  }


}