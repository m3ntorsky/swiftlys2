using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CBaseEntity : CEntityInstance, IBaseEntity {

  public CBaseEntity(nint handle) : base(handle) {
  }

  public INetworkTransmitComponent NetworkTransmitComponent {
    get => new CNetworkTransmitComponent(_Handle + Schema.GetOffset(0x9DC483B8FF010CE4));
  }
  public ref CUtlVector ThinkFunctions {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x9DC483B8D2C79415));
  }
  public ref int CurrentThinkContext {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9DC483B8B04F8BF6));
  }
  public IGameTick_t LastThinkTick {
    get => new GameTick_t(_Handle + Schema.GetOffset(0x9DC483B8CE8FE7F2));
  }
  public ref bool DisabledContextThinks {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9DC483B8C2C22BED));
  }
  public ref CBitVec<64> IsSteadyState {
    get => ref _Handle.AsRef<CBitVec<64>>(Schema.GetOffset(0x9DC483B84626D6B4));
  }
  public ref float LastNetworkChange {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9DC483B80351D699));
  }
  public ref CUtlVector ResponseContexts {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x9DC483B85120C9AE));
  }
  public ref CUtlSymbolLarge ResponseContext {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x9DC483B8ECDEFE61));
  }
  public ref float DamageAccumulator {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9DC483B85B3DCE98));
  }
  public ref MoveType_t ActualMoveType {
    get => ref _Handle.AsRef<MoveType_t>(Schema.GetOffset(0x9DC483B85600AA92));
  }
  public ref byte WaterTouch {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x9DC483B86FDAC663));
  }
  public ref byte SlimeTouch {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x9DC483B849519DFE));
  }
  public ref bool RestoreInHierarchy {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9DC483B8D3622095));
  }
  public ref CUtlSymbolLarge Target {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x9DC483B8FA08A9E8));
  }
  public ref CHandle<CBaseFilter> DamageFilter {
    get => ref _Handle.AsRef<CHandle<CBaseFilter>>(Schema.GetOffset(0x9DC483B831E01230));
  }
  public ref CUtlSymbolLarge DamageFilterName {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x9DC483B8F58A21C1));
  }
  public ref float MoveDoneTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9DC483B860639E87));
  }
  public ref Vector PrevVPhysicsUpdatePos {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x9DC483B825F6A1B4));
  }
  public ref CUtlSymbolLarge Globalname {
    get => ref _Handle.AsRef<CUtlSymbolLarge>(Schema.GetOffset(0x9DC483B82F8B8190));
  }
  public ref int SentToClients {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9DC483B81C68C809));
  }
  public ref CUtlString UniqueHammerID {
    get => ref _Handle.AsRef<CUtlString>(Schema.GetOffset(0x9DC483B84A371EB2));
  }
  public ref int SimulationTick {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9DC483B8144F0737));
  }
  public IEntityIOOutput OnKilled {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x9DC483B8A64A5BF1));
  }
  public ref Vector AbsVelocity {
    get => ref _Handle.AsRef<Vector>(Schema.GetOffset(0x9DC483B816C096CC));
  }
  public ref int PushEnumCount {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9DC483B87BDCED73));
  }
  public ICollisionProperty Collision {
    get => new CCollisionProperty(_Handle + Schema.GetOffset(0x9DC483B8C1E3AAA1));
  }
  public ref float ActualGravityScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9DC483B8386AD491));
  }
  public ref bool GravityActuallyDisabled {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9DC483B842E715B0));
  }
  public ref bool DisableLowViolence {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9DC483B8DE0FB0EE));
  }
  public ref byte WaterType {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x9DC483B81053FF74));
  }
  public ref int EFlags {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9DC483B8466C684A));
  }
  public IEntityIOOutput OnUser1 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x9DC483B8183E0806));
  }
  public IEntityIOOutput OnUser2 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x9DC483B8173E0673));
  }
  public IEntityIOOutput OnUser3 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x9DC483B8163E04E0));
  }
  public IEntityIOOutput OnUser4 {
    get => new CEntityIOOutput(_Handle + Schema.GetOffset(0x9DC483B81D3E0FE5));
  }
  public ref int InitialTeamNum {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x9DC483B807D42CFF));
  }
  public ref QAngle AngVelocity {
    get => ref _Handle.AsRef<QAngle>(Schema.GetOffset(0x9DC483B8022592E4));
  }
  public ref bool NetworkQuantizeOriginAndAngles {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9DC483B89E12171D));
  }
  public ref bool LagCompensate {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x9DC483B835099A18));
  }
  public ref CHandle<CBaseEntity> Blocker {
    get => ref _Handle.AsRef<CHandle<CBaseEntity>>(Schema.GetOffset(0x9DC483B840B754B7));
  }
  public ref float LocalTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9DC483B8E23DEFC7));
  }
  public ref float VPhysicsUpdateLocalTime {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x9DC483B8CEAEBFA5));
  }
  public IPulseGraphInstance_ServerEntity PulseGraphInstance {
    get => new CPulseGraphInstance_ServerEntity(_Handle + Schema.GetOffset(0x9DC483B87D608947));
  }

  public void CBodyComponentUpdated() {
    Schema.Update(_Handle, 0x9DC483B8D116E3C5);
  }
  public void HealthUpdated() {
    Schema.Update(_Handle, 0x9DC483B8084CDAD2);
  }
  public void MaxHealthUpdated() {
    Schema.Update(_Handle, 0x9DC483B80D159178);
  }
  public void LifeStateUpdated() {
    Schema.Update(_Handle, 0x9DC483B81C93BCF0);
  }
  public void TakesDamageUpdated() {
    Schema.Update(_Handle, 0x9DC483B8FFF5420E);
  }
  public void TakeDamageFlagsUpdated() {
    Schema.Update(_Handle, 0x9DC483B81C16CB56);
  }
  public void PlatformTypeUpdated() {
    Schema.Update(_Handle, 0x9DC483B818698BA6);
  }
  public void MoveCollideUpdated() {
    Schema.Update(_Handle, 0x9DC483B8C32EF192);
  }
  public void MoveTypeUpdated() {
    Schema.Update(_Handle, 0x9DC483B890BCCC1C);
  }
  public void SubclassIDUpdated() {
    Schema.Update(_Handle, 0x9DC483B8C02CE796);
  }
  public void AnimTimeUpdated() {
    Schema.Update(_Handle, 0x9DC483B882735D4F);
  }
  public void SimulationTimeUpdated() {
    Schema.Update(_Handle, 0x9DC483B87FCB378D);
  }
  public void CreateTimeUpdated() {
    Schema.Update(_Handle, 0x9DC483B875C91626);
  }
  public void ClientSideRagdollUpdated() {
    Schema.Update(_Handle, 0x9DC483B8F1B9C3D0);
  }
  public void InterpolationFrameUpdated() {
    Schema.Update(_Handle, 0x9DC483B8937E9619);
  }
  public void TeamNumUpdated() {
    Schema.Update(_Handle, 0x9DC483B8A5BFEFB3);
  }
  public void SpeedUpdated() {
    Schema.Update(_Handle, 0x9DC483B8C631B7EA);
  }
  public void SpawnflagsUpdated() {
    Schema.Update(_Handle, 0x9DC483B83A4BBF6B);
  }
  public void NextThinkTickUpdated() {
    Schema.Update(_Handle, 0x9DC483B8B7CEF021);
  }
  public void FlagsUpdated() {
    Schema.Update(_Handle, 0x9DC483B8A4A37590);
  }
  public void VelocityUpdated() {
    Schema.Update(_Handle, 0x9DC483B87CF77892);
  }
  public void BaseVelocityUpdated() {
    Schema.Update(_Handle, 0x9DC483B813B19DCB);
  }
  public void EffectEntityUpdated() {
    Schema.Update(_Handle, 0x9DC483B86BA85951);
  }
  public void OwnerEntityUpdated() {
    Schema.Update(_Handle, 0x9DC483B86D279C31);
  }
  public void EffectsUpdated() {
    Schema.Update(_Handle, 0x9DC483B8DF272D79);
  }
  public void GroundEntityUpdated() {
    Schema.Update(_Handle, 0x9DC483B8253120D3);
  }
  public void GroundBodyIndexUpdated() {
    Schema.Update(_Handle, 0x9DC483B81D1BA62A);
  }
  public void FrictionUpdated() {
    Schema.Update(_Handle, 0x9DC483B86F5FEBA1);
  }
  public void ElasticityUpdated() {
    Schema.Update(_Handle, 0x9DC483B84EC38DF6);
  }
  public void GravityScaleUpdated() {
    Schema.Update(_Handle, 0x9DC483B8328A3947);
  }
  public void TimeScaleUpdated() {
    Schema.Update(_Handle, 0x9DC483B8B49D735C);
  }
  public void WaterLevelUpdated() {
    Schema.Update(_Handle, 0x9DC483B86CC4285C);
  }
  public void GravityDisabledUpdated() {
    Schema.Update(_Handle, 0x9DC483B86489B245);
  }
  public void AnimatedEveryTickUpdated() {
    Schema.Update(_Handle, 0x9DC483B8FC757D7E);
  }
  public void NavIgnoreUntilTimeUpdated() {
    Schema.Update(_Handle, 0x9DC483B88228BC8B);
  }
  public void BloodTypeUpdated() {
    Schema.Update(_Handle, 0x9DC483B8E472F393);
  }
}