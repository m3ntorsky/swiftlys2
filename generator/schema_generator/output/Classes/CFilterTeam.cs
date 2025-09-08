using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFilterTeam : CBaseFilter, IFilterTeam {

  public CFilterTeam(nint handle) : base(handle) {
  }

  public ref int FilterTeam {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x46DA651D4D36160F));
  }


}