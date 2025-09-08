using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPointPush : CPointEntity, IPointPush {

  public CPointPush(nint handle) : base(handle) {
  }

  public ref bool Enabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x282695C06154EB7E));
  }
  public ref float Magnitude {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x282695C0ED0A1D8B));
  }
  public ref float Radius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x282695C05ACFC08D));
  }
  public ref float InnerRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x282695C032121407));
  }
  public ref float ConeOfInfluence {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x282695C02EA47D9C));
  }
  public ref CUtlSymbolLarge FilterName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x282695C042E1968C));
  }
  public CHandle<IBaseFilter> Filter {
    get => new CHandle<CBaseFilter>(_Handle + Schema.GetOffset(0x282695C045D9E0B1));
  }


}