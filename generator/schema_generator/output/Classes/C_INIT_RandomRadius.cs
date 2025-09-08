using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RandomRadius : CParticleFunctionInitializer, IC_INIT_RandomRadius {

  public C_INIT_RandomRadius(nint handle) : base(handle) {
  }

  public ref float RadiusMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE9419C037AEB467F));
  }
  public ref float RadiusMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE9419C0388D641D1));
  }
  public ref float RadiusRandExponent {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xE9419C03D4637A31));
  }


}