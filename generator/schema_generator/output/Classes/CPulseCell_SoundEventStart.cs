using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CPulseCell_SoundEventStart : CPulseCell_BaseFlow, IPulseCell_SoundEventStart {

  public CPulseCell_SoundEventStart(nint handle) : base(handle) {
  }

  public ref SoundEventStartType_t Type {
    get => ref _Handle.AsRef<SoundEventStartType_t>(Schema.GetOffset(0x9CC546478ED6D5CD));
  }


}