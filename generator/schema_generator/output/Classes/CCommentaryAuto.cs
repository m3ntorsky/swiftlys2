using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCommentaryAuto : CBaseEntity, ICommentaryAuto {

  public CCommentaryAuto(nint handle) : base(handle) {
  }

  public CCommentaryAuto(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public IEntityIOOutput OnCommentaryNewGame {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5BB39498C3245D97));
  }
  public IEntityIOOutput OnCommentaryMidGame {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5BB39498A1777FCB));
  }
  public IEntityIOOutput OnCommentaryMultiplayerSpawn {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x5BB3949819FDEEB2));
  }


}