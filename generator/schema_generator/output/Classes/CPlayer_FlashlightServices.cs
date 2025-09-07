using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlayer_FlashlightServices : CPlayerPawnComponent, IPlayer_FlashlightServices {

  public CPlayer_FlashlightServices(nint handle) : base(handle) {
  }

  public CPlayer_FlashlightServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}