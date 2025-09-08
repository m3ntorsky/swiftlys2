using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCS2ChickenGraphController : CAnimGraphControllerBase, ICS2ChickenGraphController {

  public CCS2ChickenGraphController(nint handle) : base(handle) {
  }

  public ISchemaUntypedField Action {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC887F1577918619F));
  }
  public ISchemaUntypedField ActionSubtype {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC887F157FC94FE0B));
  }
  public ISchemaUntypedField ActionReset {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC887F157580F422E));
  }
  public ISchemaUntypedField IdleVariation {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC887F157CF0EF118));
  }
  public ISchemaUntypedField RunVariation {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC887F1575E32595B));
  }
  public ISchemaUntypedField PanicVariation {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC887F157802F1EA1));
  }
  public ISchemaUntypedField SquatVariation {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC887F15791127162));
  }
  public ISchemaUntypedField InWater {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xC887F157E47F9BA9));
  }
  public ref bool HasActionCompletedEvent {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC887F157CD4A37EA));
  }
  public ref bool WaitingForCompletedEvent {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC887F15754876F98));
  }


}