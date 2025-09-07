using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSGO_TeamIntroCharacterPosition : CCSGO_TeamPreviewCharacterPosition, ICSGO_TeamIntroCharacterPosition {

  public CCSGO_TeamIntroCharacterPosition(nint handle) : base(handle) {
  }

  public CCSGO_TeamIntroCharacterPosition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}