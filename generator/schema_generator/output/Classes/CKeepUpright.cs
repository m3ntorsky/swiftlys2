using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CKeepUpright : CPointEntity, IKeepUpright {

  public CKeepUpright(nint handle) : base(handle) {
  }

  public ref Vector WorldGoalAxis {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB65A0D30836922ED));
  }
  public ref Vector LocalTestAxis {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xB65A0D30B678975D));
  }
  public ISchemaUntypedField NameAttach {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xB65A0D30BECAEF3F));
  }
  public ref CHandle<CBaseEntity> AttachedObject {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0xB65A0D301AE8F30A));
  }
  public ref float AngularLimit {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xB65A0D30497B8D18));
  }
  public ref bool Active {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB65A0D308334208F));
  }
  public ref bool DampAllRotation {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB65A0D30AAA70B9C));
  }


}