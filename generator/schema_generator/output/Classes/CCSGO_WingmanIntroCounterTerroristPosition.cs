using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSGO_WingmanIntroCounterTerroristPosition : CCSGO_WingmanIntroCharacterPosition, ICSGO_WingmanIntroCounterTerroristPosition {

  public CCSGO_WingmanIntroCounterTerroristPosition(nint handle) : base(handle) {
  }

  public CCSGO_WingmanIntroCounterTerroristPosition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}