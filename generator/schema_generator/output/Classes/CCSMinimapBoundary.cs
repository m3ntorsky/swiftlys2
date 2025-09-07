using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSMinimapBoundary : CBaseEntity, ICSMinimapBoundary {

  public CCSMinimapBoundary(nint handle) : base(handle) {
  }

  public CCSMinimapBoundary(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}