using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimGraphSettingsManager : SchemaClass, IAnimGraphSettingsManager {

  public CAnimGraphSettingsManager(nint handle) : base(handle) {
  }

  public ref CUtlVector SettingsGroups {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x53B994DB178D6408));
  }


}