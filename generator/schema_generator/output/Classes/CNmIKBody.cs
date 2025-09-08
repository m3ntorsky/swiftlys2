using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmIKBody : SchemaClass, INmIKBody {

  public CNmIKBody(nint handle) : base(handle) {
  }

  public ref float Mass {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2162051FCD83D263));
  }
  public ref Vector LocalMassCenter {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x2162051FAFDB4EDD));
  }
  public ref Vector Radius {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x2162051F0A9FA917));
  }
  public ref float Resistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x2162051FE15D484E));
  }


}