using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CParticleFloatInput : CParticleInput, IParticleFloatInput {

  public CParticleFloatInput(nint handle) : base(handle) {
  }

  public CParticleFloatInput(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref ParticleFloatType_t Type {
    get => ref _Handle.AsRef<ParticleFloatType_t>(Schema.GetOffset(0x4330CD3218853D59));
  }
  public ref ParticleFloatMapType_t MapType {
    get => ref _Handle.AsRef<ParticleFloatMapType_t>(Schema.GetOffset(0x4330CD3226E625A5));
  }
  public ref float LiteralValue {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD32E7C4A627));
  }
  public ISchemaUntypedField NamedValue {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x4330CD32E0618727));
  }
  public ref int ControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4330CD320D0DDF8C));
  }
  public IParticleAttributeIndex_t ScalarAttribute {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x4330CD32263301AB));
  }
  public IParticleAttributeIndex_t VectorAttribute {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x4330CD322B36D79A));
  }
  public ref int VectorComponent {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4330CD324F08EE1D));
  }
  public ref float RandomMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD32C45AD7FC));
  }
  public ref float RandomMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD32B24733EE));
  }
  public ref bool HasRandomSignFlip {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4330CD327D74FC06));
  }
  public ref int RandomSeed {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4330CD326388F067));
  }
  public ref ParticleFloatRandomMode_t RandomMode {
    get => ref _Handle.AsRef<ParticleFloatRandomMode_t>(Schema.GetOffset(0x4330CD3247E88035));
  }
  public ref float LOD0 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD32B17B2EE6));
  }
  public ref float LOD1 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD32B27B3079));
  }
  public ref float LOD2 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD32AF7B2BC0));
  }
  public ref float LOD3 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD32B07B2D53));
  }
  public IParticleAttributeIndex_t NoiseInputVectorAttribute {
    get => new ParticleAttributeIndex_t(_Handle + Schema.GetOffset(0x4330CD3229C275A0));
  }
  public ref float NoiseOutputMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD3221F9B712));
  }
  public ref float NoiseOutputMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD322BE4AC18));
  }
  public ref float NoiseScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD3232FE2EF3));
  }
  public ref Vector NoiseOffsetRate {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x4330CD322D84E8CC));
  }
  public ref float NoiseOffset {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD3245B63C18));
  }
  public ref int NoiseOctaves {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x4330CD327781A322));
  }
  public ref PFNoiseTurbulence_t NoiseTurbulence {
    get => ref _Handle.AsRef<PFNoiseTurbulence_t>(Schema.GetOffset(0x4330CD320B63A93C));
  }
  public ref PFNoiseType_t NoiseType {
    get => ref _Handle.AsRef<PFNoiseType_t>(Schema.GetOffset(0x4330CD326758ED35));
  }
  public ref PFNoiseModifier_t NoiseModifier {
    get => ref _Handle.AsRef<PFNoiseModifier_t>(Schema.GetOffset(0x4330CD32C9F3EBC8));
  }
  public ref float NoiseTurbulenceScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD3209F16918));
  }
  public ref float NoiseTurbulenceMix {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD32A2E9146C));
  }
  public ref float NoiseImgPreviewScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD32F94C82CC));
  }
  public ref bool NoiseImgPreviewLive {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4330CD327DECC7A6));
  }
  public ref float NoCameraFallback {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD3225458889));
  }
  public ref bool UseBoundsCenter {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x4330CD3203C783A4));
  }
  public ref ParticleFloatInputMode_t InputMode {
    get => ref _Handle.AsRef<ParticleFloatInputMode_t>(Schema.GetOffset(0x4330CD32266E8EC0));
  }
  public ref float MultFactor {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD32ECCE8A6A));
  }
  public ref float Input0 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD32EADA2FB7));
  }
  public ref float Input1 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD32E9DA2E24));
  }
  public ref float Output0 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD32760A07D6));
  }
  public ref float Output1 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD32770A0969));
  }
  public ref float NotchedRangeMin {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD3228E87189));
  }
  public ref float NotchedRangeMax {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD321AD4D3C7));
  }
  public ref float NotchedOutputOutside {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD32880DA9AE));
  }
  public ref float NotchedOutputInside {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD327435127B));
  }
  public ref ParticleFloatRoundType_t RoundType {
    get => ref _Handle.AsRef<ParticleFloatRoundType_t>(Schema.GetOffset(0x4330CD32A3B1B6E7));
  }
  public ref ParticleFloatBiasType_t BiasType {
    get => ref _Handle.AsRef<ParticleFloatBiasType_t>(Schema.GetOffset(0x4330CD325FAB0448));
  }
  public ref float BiasParameter {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x4330CD3215172A11));
  }
  public ISchemaUntypedField Curve {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0x4330CD323389BB94));
  }


}