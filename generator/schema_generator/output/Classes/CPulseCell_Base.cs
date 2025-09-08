using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_Base : SchemaClass, IPulseCell_Base {

  public CPulseCell_Base(nint handle) : base(handle) {
  }

  public IPulseDocNodeID_t EditorNodeID {
    get => new PulseDocNodeID_t(_Handle + Schema.GetOffset(0xA1B689158D964CBD));
  }


}