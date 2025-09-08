using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Step_EntFire : CPulseCell_BaseFlow, IPulseCell_Step_EntFire {

  public CPulseCell_Step_EntFire(nint handle) : base(handle) {
  }

  public ref CUtlString Input {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xF0F9E958942A24FB));
  }


}