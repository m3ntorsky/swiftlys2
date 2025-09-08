using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class PhysFeModelDesc_t : SchemaClass, IPhysFeModelDesc_t {

  public PhysFeModelDesc_t(nint handle) : base(handle) {
  }

  public ref CUtlVector<uint> CtrlHash {
    get => ref _Handle.AsRef<CUtlVector<uint>>(Schema.GetOffset(0x1BA439272E1897A4));
  }
  public ref CUtlVector<CUtlString> CtrlName {
    get => ref _Handle.AsRef<CUtlVector<CUtlString>>(Schema.GetOffset(0x1BA4392720EBC8FF));
  }
  public ref uint StaticNodeFlags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x1BA43927491F024E));
  }
  public ref uint DynamicNodeFlags {
    get => ref _Handle.AsRef<uint>(Schema.GetOffset(0x1BA439274F6F7661));
  }
  public ref float LocalForce {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA439275E779595));
  }
  public ref float LocalRotation {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA4392731E3CCB4));
  }
  public ref ushort NodeCount {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x1BA4392709F73A00));
  }
  public ref ushort StaticNodes {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x1BA43927A58AC0EC));
  }
  public ref ushort RotLockStaticNodes {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x1BA43927B63C3930));
  }
  public ref ushort FirstPositionDrivenNode {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x1BA439272E0F5D4C));
  }
  public ref ushort SimdTriCount1 {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x1BA439274F73E5EF));
  }
  public ref ushort SimdTriCount2 {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x1BA439275073E782));
  }
  public ref ushort SimdQuadCount1 {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x1BA439275BC6C099));
  }
  public ref ushort SimdQuadCount2 {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x1BA4392758C6BBE0));
  }
  public ref ushort QuadCount1 {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x1BA439273BC36C10));
  }
  public ref ushort QuadCount2 {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x1BA439273EC370C9));
  }
  public ref ushort TreeDepth {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x1BA439271295DF6E));
  }
  public ref ushort NodeBaseJiggleboneDependsCount {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x1BA439277F14AD2C));
  }
  public ref ushort RopeCount {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x1BA43927DC972C90));
  }
  public ref CUtlVector<ushort> Ropes {
    get => ref _Handle.AsRef<CUtlVector<ushort>>(Schema.GetOffset(0x1BA43927245D4F7A));
  }
  public ref CUtlVector NodeBases {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927D78A7829));
  }
  public ref CUtlVector SimdNodeBases {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA439276CEB34CE));
  }
  public ref CUtlVector Quads {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927F0B96887));
  }
  public ref CUtlVector SimdQuads {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA439272A528AEC));
  }
  public ref CUtlVector SimdTris {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA4392708B7DB8E));
  }
  public ref CUtlVector SimdRods {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA4392772C6F02A));
  }
  public ref CUtlVector SimdRodsAnim {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA439272F796453));
  }
  public ref CUtlVector<CTransform> InitPose {
    get => ref _Handle.AsRef<CUtlVector<CTransform>>(Schema.GetOffset(0x1BA439275E468732));
  }
  public ref CUtlVector Rods {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA439276FC1D3D7));
  }
  public ref CUtlVector Twists {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA439272079B489));
  }
  public ref CUtlVector HingeLimits {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927EDFF16F4));
  }
  public ref CUtlVector<uint> AntiTunnelBytecode {
    get => ref _Handle.AsRef<CUtlVector<uint>>(Schema.GetOffset(0x1BA43927FD33DEEC));
  }
  public ref CUtlVector DynKinLinks {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA439271F3CC98B));
  }
  public ref CUtlVector AntiTunnelProbes {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927E34A5328));
  }
  public ref CUtlVector<ushort> AntiTunnelTargetNodes {
    get => ref _Handle.AsRef<CUtlVector<ushort>>(Schema.GetOffset(0x1BA439275AB2DCE7));
  }
  public ref CUtlVector AxialEdges {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927DE90F268));
  }
  public ref CUtlVector<float> NodeInvMasses {
    get => ref _Handle.AsRef<CUtlVector<float>>(Schema.GetOffset(0x1BA439274BC4CE04));
  }
  public ref CUtlVector CtrlOffsets {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927C1ACD824));
  }
  public ref CUtlVector CtrlOsOffsets {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927C7290656));
  }
  public ref CUtlVector FollowNodes {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927ECF0783D));
  }
  public ref CUtlVector CollisionPlanes {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927B367BFCC));
  }
  public ref CUtlVector NodeIntegrator {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927940C5E1C));
  }
  public ref CUtlVector SpringIntegrator {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA4392725EF8295));
  }
  public ref CUtlVector SimdSpringIntegrator {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA439273755280C));
  }
  public ref CUtlVector WorldCollisionParams {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927BF45BE03));
  }
  public ref CUtlVector<float> LegacyStretchForce {
    get => ref _Handle.AsRef<CUtlVector<float>>(Schema.GetOffset(0x1BA43927C7AB43F6));
  }
  public ref CUtlVector<float> NodeCollisionRadii {
    get => ref _Handle.AsRef<CUtlVector<float>>(Schema.GetOffset(0x1BA43927CD59A3E0));
  }
  public ref CUtlVector<float> DynNodeFriction {
    get => ref _Handle.AsRef<CUtlVector<float>>(Schema.GetOffset(0x1BA43927B935608E));
  }
  public ref CUtlVector<float> LocalRotation {
    get => ref _Handle.AsRef<CUtlVector<float>>(Schema.GetOffset(0x1BA439275A8DBCEE));
  }
  public ref CUtlVector<float> LocalForce {
    get => ref _Handle.AsRef<CUtlVector<float>>(Schema.GetOffset(0x1BA439275274CF1B));
  }
  public ref CUtlVector TaperedCapsuleStretches {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA439271F019DBC));
  }
  public ref CUtlVector TaperedCapsuleRigids {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927F74D1937));
  }
  public ref CUtlVector SphereRigids {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927BAF34488));
  }
  public ref CUtlVector<ushort> WorldCollisionNodes {
    get => ref _Handle.AsRef<CUtlVector<ushort>>(Schema.GetOffset(0x1BA43927FF7871EA));
  }
  public ref CUtlVector<ushort> TreeParents {
    get => ref _Handle.AsRef<CUtlVector<ushort>>(Schema.GetOffset(0x1BA43927BCB1115A));
  }
  public ref CUtlVector<ushort> TreeCollisionMasks {
    get => ref _Handle.AsRef<CUtlVector<ushort>>(Schema.GetOffset(0x1BA43927E89C96B8));
  }
  public ref CUtlVector TreeChildren {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927FE09F5A2));
  }
  public ref CUtlVector<ushort> FreeNodes {
    get => ref _Handle.AsRef<CUtlVector<ushort>>(Schema.GetOffset(0x1BA43927DBDC2128));
  }
  public ref CUtlVector FitMatrices {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA439273EA416A0));
  }
  public ref CUtlVector FitWeights {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927C7FF749D));
  }
  public ref CUtlVector ReverseOffsets {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA439274F76269B));
  }
  public ref CUtlVector AnimStrayRadii {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA4392702505672));
  }
  public ref CUtlVector SimdAnimStrayRadii {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927BD404343));
  }
  public ref CUtlVector KelagerBends {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA439279DE7A8A0));
  }
  public ref CUtlVector CtrlSoftOffsets {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA439278C66B564));
  }
  public ref CUtlVector JiggleBones {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA439274F458BCC));
  }
  public ref CUtlVector<ushort> SourceElems {
    get => ref _Handle.AsRef<CUtlVector<ushort>>(Schema.GetOffset(0x1BA43927CF1C9DB0));
  }
  public ref CUtlVector<uint> GoalDampedSpringIntegrators {
    get => ref _Handle.AsRef<CUtlVector<uint>>(Schema.GetOffset(0x1BA4392770492CEE));
  }
  public ref CUtlVector Tris {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927AD4316D7));
  }
  public ref ushort TriCount1 {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x1BA43927DA287160));
  }
  public ref ushort TriCount2 {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x1BA43927DD287619));
  }
  public ref byte ReservedUint8 {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x1BA439279DB35207));
  }
  public ref byte ExtraPressureIterations {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x1BA439270749204E));
  }
  public ref byte ExtraGoalIterations {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x1BA43927628FA5BA));
  }
  public ref byte ExtraIterations {
    get => ref _Handle.AsRef<byte>(Schema.GetOffset(0x1BA4392737B28905));
  }
  public ref CUtlVector SDFRigids {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927E4F15C2C));
  }
  public ref CUtlVector BoxRigids {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA439273FF6F3EE));
  }
  public ref CUtlVector<byte> DynNodeVertexSet {
    get => ref _Handle.AsRef<CUtlVector<byte>>(Schema.GetOffset(0x1BA4392710AF881A));
  }
  public ref CUtlVector<uint> VertexSetNames {
    get => ref _Handle.AsRef<CUtlVector<uint>>(Schema.GetOffset(0x1BA439270B557437));
  }
  public ref CUtlVector RigidColliderPriorities {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927A6818704));
  }
  public ref CUtlVector MorphLayers {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA439279DF389BF));
  }
  public ref CUtlVector<byte> MorphSetData {
    get => ref _Handle.AsRef<CUtlVector<byte>>(Schema.GetOffset(0x1BA43927DA9B396B));
  }
  public ref CUtlVector VertexMaps {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA4392727EEF7FC));
  }
  public ref CUtlVector<byte> VertexMapValues {
    get => ref _Handle.AsRef<CUtlVector<byte>>(Schema.GetOffset(0x1BA43927EAF6DABD));
  }
  public ref CUtlVector Effects {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927A60AA5E5));
  }
  public ref CUtlVector LockToParent {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA43927CFC56E77));
  }
  public ref CUtlVector<ushort> LockToGoal {
    get => ref _Handle.AsRef<CUtlVector<ushort>>(Schema.GetOffset(0x1BA43927EF4703D8));
  }
  public ref CUtlVector<short> SkelParents {
    get => ref _Handle.AsRef<CUtlVector<short>>(Schema.GetOffset(0x1BA43927D2AAA7FB));
  }
  public ref CUtlVector DynNodeWindBases {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0x1BA439271ABAB644));
  }
  public ref float InternalPressure {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA43927B3CC4239));
  }
  public ref float DefaultTimeDilation {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA439271F1E706B));
  }
  public ref float Windage {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA43927606E3F48));
  }
  public ref float WindDrag {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA4392753E238D7));
  }
  public ref float DefaultSurfaceStretch {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA43927B772D9D0));
  }
  public ref float DefaultThreadStretch {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA439271386FDD5));
  }
  public ref float DefaultGravityScale {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA4392789AD0384));
  }
  public ref float DefaultVelAirDrag {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA439271833A0FB));
  }
  public ref float DefaultExpAirDrag {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA43927681CCE27));
  }
  public ref float DefaultVelQuadAirDrag {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA43927BF28F362));
  }
  public ref float DefaultExpQuadAirDrag {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA43927F16B8A2E));
  }
  public ref float RodVelocitySmoothRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA439274EDA647F));
  }
  public ref float QuadVelocitySmoothRate {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA43927A5E06553));
  }
  public ref float AddWorldCollisionRadius {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA43927EBFB7154));
  }
  public ref float DefaultVolumetricSolveAmount {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA43927D69EF547));
  }
  public ref float MotionSmoothCDT {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA439279C2571CC));
  }
  public ref float LocalDrag1 {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x1BA43927BE849FFB));
  }
  public ref ushort RodVelocitySmoothIterations {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x1BA439277B5933A3));
  }
  public ref ushort QuadVelocitySmoothIterations {
    get => ref _Handle.AsRef<ushort>(Schema.GetOffset(0x1BA4392761612B9B));
  }


}