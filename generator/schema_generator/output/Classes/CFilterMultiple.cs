using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFilterMultiple : CBaseFilter, IFilterMultiple {

  public CFilterMultiple(nint handle) : base(handle) {
  }

  public ref filter_t FilterType {
    get => ref _Handle.AsRef<filter_t>(Schema.GetOffset(0x6EA0578071861EDB));
  }
  public ISchemaFixedArray<CUtlSymbolLarge> FilterName {
    get => new SchemaFixedArray<CUtlSymbolLarge>(_Handle, 0x6EA0578009C86445, 10, 8, 8);
  }
  public CHandle<CBaseEntity> Filter {
    get => new CHandle<CBaseEntity>(_Handle, 0x6EA0578045D9E0B1, 10, 4, 4);
  }


}