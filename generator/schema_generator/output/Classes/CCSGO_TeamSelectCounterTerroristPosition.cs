using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSGO_TeamSelectCounterTerroristPosition : CCSGO_TeamSelectCharacterPosition, ICSGO_TeamSelectCounterTerroristPosition {

  public CCSGO_TeamSelectCounterTerroristPosition(nint handle) : base(handle) {
  }

  public CCSGO_TeamSelectCounterTerroristPosition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}