using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CTiltTwistConstraint : CBaseConstraint, ITiltTwistConstraint {

  public CTiltTwistConstraint(nint handle) : base(handle) {
  }

  public ref int TargetAxis {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4A56E4D341CC84D5));
  }
  public ref int SlaveAxis {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4A56E4D3CA99CDBD));
  }


}