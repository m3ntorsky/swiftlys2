using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlayer_ItemServices : CPlayerPawnComponent, IPlayer_ItemServices {

  public CPlayer_ItemServices(nint handle) : base(handle) {
  }

  public CPlayer_ItemServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}