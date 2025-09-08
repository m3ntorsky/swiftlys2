using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimGraphNetworkSettings : CAnimGraphSettingsGroup, IAnimGraphNetworkSettings {

  public CAnimGraphNetworkSettings(nint handle) : base(handle) {
  }

  public ref bool NetworkingEnabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAF5ADE2491EF35E0));
  }


}