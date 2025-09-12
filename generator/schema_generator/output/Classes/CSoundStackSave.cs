using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSoundStackSave : CLogicalEntity, ISoundStackSave {

  public CSoundStackSave(nint handle) : base(handle) {
  }

  public ISchemaUntypedField StackName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xF9E7A22E3B3E9CD4));
  }


}