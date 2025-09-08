using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointEntityFinder : CBaseEntity, IPointEntityFinder {

  public CPointEntityFinder(nint handle) : base(handle) {
  }

  public CHandle<IBaseEntity> Entity {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0xC59CB1336EBADCB0));
  }
  public ref CUtlSymbolLarge FilterName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xC59CB13309C86445));
  }
  public CHandle<IBaseFilter> Filter {
    get => new CHandle<CBaseFilter>(_Handle + Schema.GetOffset(0xC59CB13345D9E0B1));
  }
  public ref CUtlSymbolLarge RefName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xC59CB1339640D172));
  }
  public CHandle<IBaseEntity> Reference {
    get => new CHandle<CBaseEntity>(_Handle + Schema.GetOffset(0xC59CB1338100A1A4));
  }
  public ref EntFinderMethod_t FindMethod {
    get => ref _Handle.AsRef<EntFinderMethod_t>(Schema.GetOffset(0xC59CB1331B37C627));
  }
  public IEntityIOOutput OnFoundEntity {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0xC59CB133119B4E6F));
  }


}