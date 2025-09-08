using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PARTICLE_EHANDLE__ : SchemaClass, IPARTICLE_EHANDLE__ {

  public PARTICLE_EHANDLE__(nint handle) : base(handle) {
  }

  public ref int Unused {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x7E4CC5CF85CF281B));
  }


}