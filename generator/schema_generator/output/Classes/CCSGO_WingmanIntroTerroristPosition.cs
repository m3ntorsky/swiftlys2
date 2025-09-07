using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSGO_WingmanIntroTerroristPosition : CCSGO_WingmanIntroCharacterPosition, ICSGO_WingmanIntroTerroristPosition {

  public CCSGO_WingmanIntroTerroristPosition(nint handle) : base(handle) {
  }

  public CCSGO_WingmanIntroTerroristPosition(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }




}