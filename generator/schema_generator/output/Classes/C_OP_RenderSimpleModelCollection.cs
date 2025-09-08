using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RenderSimpleModelCollection : CParticleFunctionRenderer, IC_OP_RenderSimpleModelCollection {

  public C_OP_RenderSimpleModelCollection(nint handle) : base(handle) {
  }

  public ref bool CenterOffset {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFCE69AE8E2C912BF));
  }
  public ref CStrongHandle<InfoForResourceTypeCModel> Model {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeCModel>>(Schema.GetOffset(0xFCE69AE8E100C814));
  }
  public IParticleModelInput ModelInput {
    get => new CParticleModelInput(_Handle + Schema.GetOffset(0xFCE69AE8EB74120E));
  }
  public IParticleCollectionFloatInput SizeCullScale {
    get => new CParticleCollectionFloatInput(_Handle + Schema.GetOffset(0xFCE69AE89AB1415E));
  }
  public ref bool DisableShadows {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFCE69AE8161A1880));
  }
  public ref bool DisableMotionBlur {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFCE69AE80A3CF924));
  }
  public ref bool AcceptsDecals {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xFCE69AE83D83AB88));
  }
  public IPerParticleFloatInput DrawFilter {
    get => new CPerParticleFloatInput(_Handle + Schema.GetOffset(0xFCE69AE8FD854541));
  }
  public IParticleAttributeIndex_t AngularVelocityField {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xFCE69AE81A8493FE));
  }


}