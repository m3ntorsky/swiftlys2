using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_SequenceLifeTime : CParticleFunctionInitializer, IC_INIT_SequenceLifeTime {

  public C_INIT_SequenceLifeTime(nint handle) : base(handle) {
  }

  public C_INIT_SequenceLifeTime(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref float Framerate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xC4BD3FF8F4EAA666));
  }


}