using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class C_OP_RemapNamedModelElementOnceTimed : CParticleFunctionOperator, IC_OP_RemapNamedModelElementOnceTimed {

  public C_OP_RemapNamedModelElementOnceTimed(nint handle) : base(handle) {
  }

  public ref CStrongHandle<InfoForResourceTypeCModel> Model {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeCModel>>(Schema.GetOffset(0xBD6F6D8CE100C814));
  }
  public ref CUtlVector<CUtlString> InNames {
    get => ref _Handle.AsRef<CUtlVector<CUtlString>>(Schema.GetOffset(0xBD6F6D8CC6BEF30A));
  }
  public ref CUtlVector<CUtlString> OutNames {
    get => ref _Handle.AsRef<CUtlVector<CUtlString>>(Schema.GetOffset(0xBD6F6D8C4AEE2CFD));
  }
  public ref CUtlVector<CUtlString> FallbackNames {
    get => ref _Handle.AsRef<CUtlVector<CUtlString>>(Schema.GetOffset(0xBD6F6D8C5C686169));
  }
  public ref bool ModelFromRenderer {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBD6F6D8CAEBA1F25));
  }
  public ref bool Proportional {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xBD6F6D8C891F328A));
  }
  public IParticleAttributeIndex_t FieldInput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xBD6F6D8CAE775669));
  }
  public IParticleAttributeIndex_t FieldOutput {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0xBD6F6D8CE5729606));
  }
  public ref float RemapTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xBD6F6D8CF436AC39));
  }


}