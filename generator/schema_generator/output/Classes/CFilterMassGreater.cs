using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CFilterMassGreater : CBaseFilter, IFilterMassGreater {

  public CFilterMassGreater(nint handle) : base(handle) {
  }

  public ref float FilterMass {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBF74FA22FF3F08E7));
  }


}