using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPlayer_UseServices : CPlayerPawnComponent, IPlayer_UseServices {

  public CPlayer_UseServices(nint handle) : base(handle) {
  }

  public CPlayer_UseServices(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}