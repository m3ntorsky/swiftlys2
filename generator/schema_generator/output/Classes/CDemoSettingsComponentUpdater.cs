using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CDemoSettingsComponentUpdater : CAnimComponentUpdater, IDemoSettingsComponentUpdater {

  public CDemoSettingsComponentUpdater(nint handle) : base(handle) {
  }

  public IAnimDemoCaptureSettings Settings {
    get => new CAnimDemoCaptureSettings(_Handle + Schema.GetOffset(0xD4FC646CB3DE33A8));
  }


}