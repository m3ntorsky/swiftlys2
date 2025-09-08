using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_InitFromParentKilled : CParticleFunctionInitializer, IC_INIT_InitFromParentKilled {

  public C_INIT_InitFromParentKilled(nint handle) : base(handle) {
  }

  public IParticleAttributeIndex_t AttributeToCopy {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x4CE3F9811953739B));
  }
  public ref EventTypeSelection_t EventType {
    get => ref _Handle.AsRef<EventTypeSelection_t>(Schema.GetOffset(0x4CE3F981E1F9AA93));
  }


}