using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CAnimGraphSettingsGroup : SchemaClass, IAnimGraphSettingsGroup {

  public CAnimGraphSettingsGroup(nint handle) : base(handle) {
  }

  public CAnimGraphSettingsGroup(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}