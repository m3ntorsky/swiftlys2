using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class FloatInputMaterialVariable_t : SchemaClass, IFloatInputMaterialVariable_t {

  public FloatInputMaterialVariable_t(nint handle) : base(handle) {
  }

  public ref CUtlString StrVariable {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xEFEA50FDA52C3390));
  }
  public IParticleCollectionFloatInput Input {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xEFEA50FD1D4B7FFD));
  }


}