using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ParticleChildrenInfo_t : SchemaClass, IParticleChildrenInfo_t {

  public ParticleChildrenInfo_t(nint handle) : base(handle) {
  }

  public CStrongHandle<IInfoForResourceTypeIParticleSystemDefinition> ChildRef {
    get => new CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>(_Handle + Schema.GetOffset(0x1EF548F3D87838A));
  }
  public ref float Delay {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1EF548F7D68FD6E));
  }
  public ref bool EndCap {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1EF548FC47CB04A));
  }
  public ref bool DisableChild {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x1EF548F81AECD9B));
  }
  public ref ParticleDetailLevel_t DetailLevel {
    get => ref _Handle.AsRef<ParticleDetailLevel_t>(Schema.GetOffset(0x1EF548F11D9E786));
  }


}