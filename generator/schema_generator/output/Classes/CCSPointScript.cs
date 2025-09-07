using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CCSPointScript : CBasePulseGraphInstance, ICSPointScript {

  public CCSPointScript(nint handle) : base(handle) {
  }

  public CCSPointScript(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ICSPointScriptEntity Parent {
    get => new CCSPointScriptEntity(_Handle + Schema.GetOffset(0xE179A65B89C7C3F));
  }


}