using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class vphysics_save_cphysicsbody_t : RnBodyDesc_t, Ivphysics_save_cphysicsbody_t {

  public vphysics_save_cphysicsbody_t(nint handle) : base(handle) {
  }

  public ref ulong OldPointer {
    get => ref _Handle.AsRef<ulong>(Schema.GetOffset(0xC6818B0AA60623F3));
  }


}