using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CLogicNavigation : CLogicalEntity, ILogicNavigation {

  public CLogicNavigation(nint handle) : base(handle) {
  }

  public ref bool IsOn {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x8E444D6254B260A0));
  }
  public ref navproperties_t NavProperty {
    get => ref _Handle.AsRef<navproperties_t>(Schema.GetOffset(0x8E444D62C9E0B3E7));
  }


}