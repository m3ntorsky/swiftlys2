using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSGO_TeamSelectTerroristPosition : CCSGO_TeamSelectCharacterPosition, ICSGO_TeamSelectTerroristPosition {

  public CCSGO_TeamSelectTerroristPosition(nint handle) : base(handle) {
  }

  public CCSGO_TeamSelectTerroristPosition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}