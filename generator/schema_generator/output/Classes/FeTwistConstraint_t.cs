using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FeTwistConstraint_t : SchemaClass, IFeTwistConstraint_t {

  public FeTwistConstraint_t(nint handle) : base(handle) {
  }

  public FeTwistConstraint_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ushort NodeOrient {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x4BD7707B59026ED8));
  }
  public ref ushort NodeEnd {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x4BD7707B8A00317E));
  }
  public ref float TwistRelax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4BD7707B9E4510FC));
  }
  public ref float SwingRelax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4BD7707BE4722697));
  }


}