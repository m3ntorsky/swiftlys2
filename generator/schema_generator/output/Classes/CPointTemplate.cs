using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointTemplate : CLogicalEntity, IPointTemplate {

  public CPointTemplate(nint handle) : base(handle) {
  }

  public CPointTemplate(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlSymbolLarge WorldName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x7085DB4EB1FC5B40));
  }
  public ref CUtlSymbolLarge Source2EntityLumpName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x7085DB4EC0B648BC));
  }
  public ref CUtlSymbolLarge EntityFilterName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x7085DB4E3BCB3E97));
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
  public ref CUtlVector< uint32 > CreatedSpawnGroupHandles {
    get => ref _Handle.AsRef<CUtlVector< uint32 >>(Schema.GetOffset(0x7085DB4EF66F13E4));
  }
  public ref CUtlVector< CEntityHandle > SpawnedEntityHandles {
    get => ref _Handle.AsRef<CUtlVector< CEntityHandle >>(Schema.GetOffset(0x7085DB4EAFF1C191));
  }
  public ISchemaUntypedField ScriptSpawnCallback {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x7085DB4EAD74D892));
  }
  public ISchemaUntypedField ScriptCallbackScope {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x7085DB4E3B18B033));
  }


}