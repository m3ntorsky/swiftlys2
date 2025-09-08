using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMultiLightProxy : CLogicalEntity, IMultiLightProxy {

  public CMultiLightProxy(nint handle) : base(handle) {
  }

  public ref CUtlSymbolLarge LightNameFilter {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xF2B647B3071F3A26));
  }
  public ref CUtlSymbolLarge LightClassFilter {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0xF2B647B32B566D5B));
  }
  public ref float LightRadiusFilter {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF2B647B3DBC59891));
  }
  public ref float BrightnessDelta {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF2B647B3E60D5182));
  }
  public ref bool PerformScreenFade {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xF2B647B3F3DAE928));
  }
  public ref float TargetBrightnessMultiplier {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF2B647B3B84CF4BA));
  }
  public ref float CurrentBrightnessMultiplier {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xF2B647B3C03C5EEC));
  }
  public ref CUtlVector Lights {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xF2B647B3A5ECA534));
  }


}