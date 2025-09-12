using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicMeasureMovement : CLogicalEntity, ILogicMeasureMovement {

  public CLogicMeasureMovement(nint handle) : base(handle) {
  }

  public ISchemaUntypedField StrMeasureTarget {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x11EA274585646A89));
  }
  public ISchemaUntypedField StrMeasureReference {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x11EA2745CF4AF1BD));
  }
  public ISchemaUntypedField StrTargetReference {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x11EA27453E928D56));
  }
  public ref CHandle<CBaseEntity> MeasureTarget {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x11EA2745F81BC1A8));
  }
  public ref CHandle<CBaseEntity> MeasureReference {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x11EA274567F65D7A));
  }
  public ref CHandle<CBaseEntity> Target {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x11EA2745CE35901A));
  }
  public ref CHandle<CBaseEntity> TargetReference {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x11EA2745EB33504F));
  }
  public ref float Scale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x11EA2745B731A42F));
  }
  public ref int MeasureType {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x11EA274593190C1B));
  }


}