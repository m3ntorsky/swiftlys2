using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimGraphSettingsManager : SchemaClass, IAnimGraphSettingsManager {

  public CAnimGraphSettingsManager(nint handle) : base(handle) {
  }

  public CAnimGraphSettingsManager(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CSmartPtr< CAnimGraphSettingsGroup > > SettingsGroups {
    get => ref _Handle.AsRef<CUtlVector< CSmartPtr< CAnimGraphSettingsGroup > >>(Schema.GetOffset(0x53B994DB178D6408));
  }


}