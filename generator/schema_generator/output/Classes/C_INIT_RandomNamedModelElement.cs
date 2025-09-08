using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RandomNamedModelElement : CParticleFunctionInitializer, IC_INIT_RandomNamedModelElement {

  public C_INIT_RandomNamedModelElement(nint handle) : base(handle) {
  }

  public CStrongHandle<IInfoForResourceTypeCModel> Model {
    get => new CStrongHandle<InfoForResourceTypeCModel>(_Handle + Schema.GetOffset(0xA3E776D5E100C814));
  }
  public ref CUtlVector<CUtlString> Names {
    get => ref _Handle.AsRef<CUtlVector<CUtlString>>(Schema.GetOffset(0xA3E776D50DA776AF));
  }
  public ref bool Shuffle {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA3E776D528BD2B2E));
  }
  public ref bool Linear {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA3E776D5B9313720));
  }
  public ref bool ModelFromRenderer {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xA3E776D5AEBA1F25));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xA3E776D5E5729606));
  }


}