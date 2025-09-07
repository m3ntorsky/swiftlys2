using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSGO_WingmanIntroCharacterPosition : CCSGO_TeamIntroCharacterPosition, ICSGO_WingmanIntroCharacterPosition {

  public CCSGO_WingmanIntroCharacterPosition(nint handle) : base(handle) {
  }

  public CCSGO_WingmanIntroCharacterPosition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}