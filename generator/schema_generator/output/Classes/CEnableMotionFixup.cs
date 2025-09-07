using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CEnableMotionFixup : CBaseEntity, IEnableMotionFixup {

  public CEnableMotionFixup(nint handle) : base(handle) {
  }

  public CEnableMotionFixup(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}