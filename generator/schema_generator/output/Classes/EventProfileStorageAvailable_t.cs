using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class EventProfileStorageAvailable_t : SchemaClass, IEventProfileStorageAvailable_t {

  public EventProfileStorageAvailable_t(nint handle) : base(handle) {
  }

  public ref CSplitScreenSlot SplitScreenSlot {
    get => ref _Handle.AsRef<CSplitScreenSlot>(Schema.GetOffset(0x871602F7DB96ED47));
  }


}