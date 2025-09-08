using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapNamedModelElementEndCap : CParticleFunctionOperator, IC_OP_RemapNamedModelElementEndCap {

  public C_OP_RemapNamedModelElementEndCap(nint handle) : base(handle) {
  }

  public CStrongHandle<IInfoForResourceTypeCModel> Model {
    get => new CStrongHandle<InfoForResourceTypeCModel>(_Handle + Schema.GetOffset(0xC434ECD3E100C814));
  }
  public ref CUtlVector<CUtlString> InNames {
    get => ref _Handle.AsRef<CUtlVector<CUtlString>>(Schema.GetOffset(0xC434ECD3C6BEF30A));
  }
  public ref CUtlVector<CUtlString> OutNames {
    get => ref _Handle.AsRef<CUtlVector<CUtlString>>(Schema.GetOffset(0xC434ECD34AEE2CFD));
  }
  public ref CUtlVector<CUtlString> FallbackNames {
    get => ref _Handle.AsRef<CUtlVector<CUtlString>>(Schema.GetOffset(0xC434ECD35C686169));
  }
  public ref bool ModelFromRenderer {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xC434ECD3AEBA1F25));
  }
  public IParticleAttributeIndex_t FieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xC434ECD3AE775669));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xC434ECD3E5729606));
  }


}