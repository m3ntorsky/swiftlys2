using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPointScript : CBasePulseGraphInstance, ICSPointScript {

  public CCSPointScript(nint handle) : base(handle) {
  }

  public ICSPointScriptEntity Parent {
    get => new CCSPointScriptEntity(_Handle + Schema.GetOffset(0xE179A65B89C7C3F));
  }


}