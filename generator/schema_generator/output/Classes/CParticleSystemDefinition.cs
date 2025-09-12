using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CParticleSystemDefinition : IParticleSystemDefinition, IParticleSystemDefinition {

  public CParticleSystemDefinition(nint handle) : base(handle) {
  }

  public ref int BehaviorVersion {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA4320E001EEB9D5));
  }
  public ref CUtlVector<PointerTo<CParticleFunctionPreEmission>> PreEmissionOperators {
    get => ref _Handle.AsRef<CUtlVector<PointerTo<CParticleFunctionPreEmission>>>(Schema.GetOffset(0xDA4320E0805AFF22));
  }
  public ref CUtlVector<PointerTo<CParticleFunctionEmitter>> Emitters {
    get => ref _Handle.AsRef<CUtlVector<PointerTo<CParticleFunctionEmitter>>>(Schema.GetOffset(0xDA4320E0C459029A));
  }
  public ref CUtlVector<PointerTo<CParticleFunctionInitializer>> Initializers {
    get => ref _Handle.AsRef<CUtlVector<PointerTo<CParticleFunctionInitializer>>>(Schema.GetOffset(0xDA4320E033FFD058));
  }
  public ref CUtlVector<PointerTo<CParticleFunctionOperator>> Operators {
    get => ref _Handle.AsRef<CUtlVector<PointerTo<CParticleFunctionOperator>>>(Schema.GetOffset(0xDA4320E08B4B170A));
  }
  public ref CUtlVector<PointerTo<CParticleFunctionForce>> ForceGenerators {
    get => ref _Handle.AsRef<CUtlVector<PointerTo<CParticleFunctionForce>>>(Schema.GetOffset(0xDA4320E00EBFE04E));
  }
  public ref CUtlVector<PointerTo<CParticleFunctionConstraint>> Constraints {
    get => ref _Handle.AsRef<CUtlVector<PointerTo<CParticleFunctionConstraint>>>(Schema.GetOffset(0xDA4320E03B02100B));
  }
  public ref CUtlVector<PointerTo<CParticleFunctionRenderer>> Renderers {
    get => ref _Handle.AsRef<CUtlVector<PointerTo<CParticleFunctionRenderer>>>(Schema.GetOffset(0xDA4320E065610B77));
  }
  public ref CUtlVector Children {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xDA4320E0D0827652));
  }
  public ref int FirstMultipleOverride_BackwardCompat {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA4320E070B95011));
  }
  public ref int InitialParticles {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA4320E0AFBEAE36));
  }
  public ref int MaxParticles {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA4320E01D53BB94));
  }
  public ref int GroupID {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA4320E03BB05135));
  }
  public ref Vector BoundingBoxMin {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xDA4320E06B6E213E));
  }
  public ref Vector BoundingBoxMax {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xDA4320E07D5AB5DC));
  }
  public ref float DepthSortBias {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E0D8EE79D9));
  }
  public ref int SortOverridePositionCP {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA4320E0384CD411));
  }
  public ref bool InfiniteBounds {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDA4320E0ABC153F0));
  }
  public ref bool EnableNamedValues {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDA4320E050DBA721));
  }
  public ref CUtlString NamedValueDomain {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0xDA4320E0D00B8FCB));
  }
  public ref CUtlVector<PointerTo<ParticleNamedValueSource_t>> NamedValueLocals {
    get => ref _Handle.AsRef<CUtlVector<PointerTo<ParticleNamedValueSource_t>>>(Schema.GetOffset(0xDA4320E02F97EB6F));
  }
  public ref Color ConstantColor {
    get => ref _Handle.AsRef<Color>(Schema.GetOffset(0xDA4320E09FC64C18));
  }
  public ref Vector ConstantNormal {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0xDA4320E07C056212));
  }
  public ref float ConstantRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E0C9ED3339));
  }
  public ref float ConstantRotation {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E0628B0815));
  }
  public ref float ConstantRotationSpeed {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E0E6BFD610));
  }
  public ref float ConstantLifespan {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E03B07FD5D));
  }
  public ref int ConstantSequenceNumber {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA4320E0EC8561B5));
  }
  public ref int ConstantSequenceNumber1 {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA4320E0D9F882CC));
  }
  public ref int SnapshotControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA4320E0192638EC));
  }
  public ref CStrongHandle<InfoForResourceTypeIParticleSnapshot> Snapshot {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeIParticleSnapshot>>(Schema.GetOffset(0xDA4320E0FB69CF2F));
  }
  public ref CStrongHandle<InfoForResourceTypeIParticleSystemDefinition> CullReplacementName {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>>(Schema.GetOffset(0xDA4320E0F766ED25));
  }
  public ref float CullRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E0E52D3471));
  }
  public ref float CullFillCost {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E0C60C53D3));
  }
  public ref int CullControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA4320E0E0BBD6A4));
  }
  public ref CStrongHandle<InfoForResourceTypeIParticleSystemDefinition> Fallback {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>>(Schema.GetOffset(0xDA4320E0E0481D45));
  }
  public ref int FallbackMaxCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA4320E097AF336E));
  }
  public ref CStrongHandle<InfoForResourceTypeIParticleSystemDefinition> LowViolenceDef {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>>(Schema.GetOffset(0xDA4320E012A2B819));
  }
  public ref CStrongHandle<InfoForResourceTypeIParticleSystemDefinition> ReferenceReplacement {
    get => ref _Handle.AsRef<CStrongHandle<InfoForResourceTypeIParticleSystemDefinition>>(Schema.GetOffset(0xDA4320E0676869A0));
  }
  public ref float PreSimulationTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E0353642D6));
  }
  public ref float StopSimulationAfterTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E0154D0AB7));
  }
  public ref float MaximumTimeStep {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E09D495584));
  }
  public ref float MaximumSimTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E02A2FD0BF));
  }
  public ref float MinimumSimTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E0C8BEDB09));
  }
  public ref float MinimumTimeStep {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E0FEC1858A));
  }
  public ref int MinimumFrames {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA4320E0C0B1A451));
  }
  public ref int MinCPULevel {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA4320E0E99C0DA7));
  }
  public ref int MinGPULevel {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA4320E02F78732B));
  }
  public ref float NoDrawTimeToGoToSleep {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E02ACD5184));
  }
  public ref float MaxDrawDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E08E4CDFA2));
  }
  public ref float StartFadeDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E04F680B0C));
  }
  public ref float MaxCreationDistance {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E0E978F3BD));
  }
  public ref int AggregationMinAvailableParticles {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA4320E0327D71FD));
  }
  public ref float AggregateRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0xDA4320E0352430AC));
  }
  public ref bool ShouldBatch {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDA4320E0D8D847F6));
  }
  public ref bool ShouldHitboxesFallbackToRenderBounds {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDA4320E08B4E62F2));
  }
  public ref bool ShouldHitboxesFallbackToSnapshot {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDA4320E02D6E6B93));
  }
  public ref bool ShouldHitboxesFallbackToCollisionHulls {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDA4320E05E66E94F));
  }
  public ref InheritableBoolType_t ViewModelEffect {
    get => ref _Handle.AsRef<InheritableBoolType_t>(Schema.GetOffset(0xDA4320E06B068FD0));
  }
  public ref bool ScreenSpaceEffect {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDA4320E0175D9268));
  }
  public ISchemaUntypedField TargetLayerID {
    get => new SchemaUntypedField(_Handle + Schema.GetOffset(0xDA4320E0FD7195C9));
  }
  public ref int SkipRenderControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA4320E091966FFF));
  }
  public ref int AllowRenderControlPoint {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xDA4320E03455C797));
  }
  public ref bool ShouldSort {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0xDA4320E0DCA74CFA));
  }
  public ref CUtlVector ControlPointConfigurations {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xDA4320E09B7B10E3));
  }


}