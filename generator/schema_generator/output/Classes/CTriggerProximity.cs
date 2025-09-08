using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTriggerProximity : CBaseTrigger, ITriggerProximity {

  public CTriggerProximity(nint handle) : base(handle) {
  }

  public CHandle<IBaseEntity> MeasureTarget {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0x98F0621FF81BC1A8));
  }
  public ref CUtlSymbolLarge MeasureTarget {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x98F0621F29C47B3A));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x98F0621F2E1F6E07));
  }
  public ref int Touchers {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x98F0621FA0F3A2B0));
  }
  public ISchemaUntypedField NearestEntityDistance {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x98F0621F28AD73D5));
  }


}