using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class RagdollCreationParams_t : SchemaClass, IRagdollCreationParams_t {

  public RagdollCreationParams_t(nint handle) : base(handle) {
  }

  public RagdollCreationParams_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref Vector Force {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xAF0FCC44E530B0A8));
  }
  public ref int ForceBone {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xAF0FCC44DDAC019E));
  }
  public ref bool ForceCurrentWorldTransform {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAF0FCC443FC20379));
  }
  public ref bool UseLRURetirement {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xAF0FCC444DCF62FA));
  }
  public ref int HealthToGrant {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xAF0FCC4414E28C5C));
  }


}