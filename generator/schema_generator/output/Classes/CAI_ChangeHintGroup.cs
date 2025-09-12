using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAI_ChangeHintGroup : CBaseEntity, IAI_ChangeHintGroup {

  public CAI_ChangeHintGroup(nint handle) : base(handle) {
  }

  public ref int SearchType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xE2F9617B09088830));
  }
  public ISchemaUntypedField StrSearchName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xE2F9617B8A77B967));
  }
  public ISchemaUntypedField StrNewHintGroup {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xE2F9617BD4585F62));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE2F9617B5ACFC08D));
  }


}