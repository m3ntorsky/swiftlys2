using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFuncVehicleClip : CBaseModelEntity, IFuncVehicleClip {

  public CFuncVehicleClip(nint handle) : base(handle) {
  }

  public CFuncVehicleClip(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}