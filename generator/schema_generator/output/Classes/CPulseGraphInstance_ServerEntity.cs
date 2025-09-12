using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseGraphInstance_ServerEntity : CBasePulseGraphInstance, IPulseGraphInstance_ServerEntity {

  public CPulseGraphInstance_ServerEntity(nint handle) : base(handle) {
  }

  public ref CHandle<CBaseEntity> Owner {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x6DFF458BF6D89572));
  }
  public ref bool Activated {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x6DFF458BF8E37A5C));
  }
  public ISchemaUntypedField NameFixupStaticPrefix {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6DFF458BFFD2D6AB));
  }
  public ISchemaUntypedField NameFixupParent {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6DFF458B7B08ECF1));
  }
  public ISchemaUntypedField NameFixupLocal {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6DFF458B508F29A4));
  }
  public ISchemaUntypedField ProceduralWorldNameForRelays {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x6DFF458B05373F31));
  }


}