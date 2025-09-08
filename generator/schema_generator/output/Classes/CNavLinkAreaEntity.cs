using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNavLinkAreaEntity : CPointEntity, INavLinkAreaEntity {

  public CNavLinkAreaEntity(nint handle) : base(handle) {
  }

  public ref float Width {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1A0F1851B91935E1));
  }
  public ref Vector LocatorOffset {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x1A0F185198225106));
  }
  public ref QAngle LocatorAnglesOffset {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x1A0F18517AFB1B3D));
  }
  public ref CUtlSymbolLarge StrMovementForward {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x1A0F18517B8433BA));
  }
  public ref CUtlSymbolLarge StrMovementReverse {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x1A0F1851E8768AA5));
  }
  public ref bool Enabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1A0F18516154EB7E));
  }
  public ref bool AllowCrossMovableConnections {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1A0F1851A1D23BD9));
  }
  public ref CUtlSymbolLarge StrFilterName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x1A0F1851E3C44CC9));
  }
  public ref CHandle<CBaseFilter> Filter {
    get => ref _Handle.AsRef<CHandle<CBaseFilter>>(Schema.GetOffset(0x1A0F185145D9E0B1));
  }
  public IEntityIOOutput OnNavLinkStart {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1A0F185115E018DB));
  }
  public IEntityIOOutput OnNavLinkFinish {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x1A0F1851A3060EA6));
  }
  public ref bool IsTerminus {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1A0F1851CBA4EAB8));
  }
  public ref int Splits {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x1A0F185146EE14AC));
  }


}