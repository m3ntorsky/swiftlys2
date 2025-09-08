using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_INIT_RemapParticleCountToNamedModelElementScalar : C_INIT_RemapParticleCountToScalar, IC_INIT_RemapParticleCountToNamedModelElementScalar {

  public C_INIT_RemapParticleCountToNamedModelElementScalar(nint handle) : base(handle) {
  }

  public ref CStrongHandle<InfoForResourceTypeCModel> Model {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeCModel>>(Schema.GetOffset(0xB011C761E100C814));
  }
  public ref CUtlString OutputMinName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xB011C761CF5C20FB));
  }
  public ref CUtlString OutputMaxName {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xB011C761553184F9));
  }
  public ref bool ModelFromRenderer {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xB011C761AEBA1F25));
  }


}