using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class ParticleNamedValueSource_t : SchemaClass, IParticleNamedValueSource_t {

  public ParticleNamedValueSource_t(nint handle) : base(handle) {
  }

  public ParticleNamedValueSource_t(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlString Name {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x740B6BEFCAE8A266));
  }
  public ref bool IsPublic {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x740B6BEFD2D88EB0));
  }
  public ref PulseValueType_t ValueType {
    get => ref _Handle.AsRef<PulseValueType_t>(Schema.GetOffset(0x740B6BEFC2A673CA));
  }
  public IParticleNamedValueConfiguration_t DefaultConfig {
    get => new ParticleNamedValueConfiguration_t(_Handle + Schema.GetOffset(0x740B6BEF05A58128));
  }
  public ref CUtlVector< ParticleNamedValueConfiguration_t > NamedConfigs {
    get => ref _Handle.AsRef<CUtlVector< ParticleNamedValueConfiguration_t >>(Schema.GetOffset(0x740B6BEF07A72469));
  }


}