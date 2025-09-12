using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointTemplate : CLogicalEntity, IPointTemplate {

  public CPointTemplate(nint handle) : base(handle) {
  }

  public ISchemaUntypedField WorldName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x7085DB4EB1FC5B40));
  }
  public ISchemaUntypedField Source2EntityLumpName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x7085DB4EC0B648BC));
  }
  public ISchemaUntypedField EntityFilterName {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x7085DB4E3BCB3E97));
  }
  public ref float TimeoutInterval {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x7085DB4E354D6687));
  }
  public ref bool AsynchronouslySpawnEntities {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x7085DB4E5371B8CE));
  }
  public ref PointTemplateClientOnlyEntityBehavior_t ClientOnlyEntityBehavior {
    get => ref _Handle.AsRef<PointTemplateClientOnlyEntityBehavior_t>(Schema.GetOffset(0x7085DB4EF26096D5));
  }
  public ref PointTemplateOwnerSpawnGroupType_t OwnerSpawnGroupType {
    get => ref _Handle.AsRef<PointTemplateOwnerSpawnGroupType_t>(Schema.GetOffset(0x7085DB4EFAC3C132));
  }
  public ref CUtlVector<uint> CreatedSpawnGroupHandles {
    get => ref _Handle.AsRef<CUtlVector<uint>>(Schema.GetOffset(0x7085DB4EF66F13E4));
  }
  public ref CUtlVector<CHandle<IEntityInstance>> SpawnedEntityHandles {
    get => ref _Handle.AsRef<CUtlVector<CHandle<IEntityInstance>>>(Schema.GetOffset(0x7085DB4EAFF1C191));
  }
  public ISchemaUntypedField ScriptSpawnCallback {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x7085DB4EAD74D892));
  }
  public ISchemaUntypedField ScriptCallbackScope {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x7085DB4E3B18B033));
  }


}