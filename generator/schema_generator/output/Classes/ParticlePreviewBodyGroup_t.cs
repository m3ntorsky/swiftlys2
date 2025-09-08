using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ParticlePreviewBodyGroup_t : SchemaClass, IParticlePreviewBodyGroup_t {

  public ParticlePreviewBodyGroup_t(nint handle) : base(handle) {
  }

  public ref CUtlString BodyGroupName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xB53436EB1E953217));
  }
  public ref int Value {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB53436EB077D337E));
  }


}