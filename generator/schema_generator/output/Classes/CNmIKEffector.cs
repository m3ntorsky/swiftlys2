using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmIKEffector : SchemaClass, INmIKEffector {

  public CNmIKEffector(nint handle) : base(handle) {
  }

  public CNmIKEffector(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref int BodyIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xA45D61F2B50B497));
  }
  public ref bool Enabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA45D61F6154EB7E));
  }
  public ref Vector TargetPosition {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xA45D61FF028CBBF));
  }
  public ref Quaternion TargetOrientation {
    get => ref _Handle.AsRef<Quaternion>(Schema.GetOffset(0xA45D61FED14ED41));
  }
  public ref float Weight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xA45D61F7B81E7AB));
  }


}