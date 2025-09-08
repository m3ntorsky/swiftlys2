using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RotatorQueueEntry_t : SchemaClass, IRotatorQueueEntry_t {

  public RotatorQueueEntry_t(nint handle) : base(handle) {
  }

  public ref Quaternion Target {
    get => ref _Handle.AsRef<Quaternion>(Schema.GetOffset(0x2A6B84384FFCC265));
  }
  public ref RotatorTargetSpace_t Space {
    get => ref _Handle.AsRef<RotatorTargetSpace_t>(Schema.GetOffset(0x2A6B8438EC1BD596));
  }


}