using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSGO_TeamSelectCharacterPosition : CCSGO_TeamPreviewCharacterPosition, ICSGO_TeamSelectCharacterPosition {

  public CCSGO_TeamSelectCharacterPosition(nint handle) : base(handle) {
  }

  public CCSGO_TeamSelectCharacterPosition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}