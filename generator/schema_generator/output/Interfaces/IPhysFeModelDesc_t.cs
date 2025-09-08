using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IPhysFeModelDesc_t : ISchemaClass {

  public ref CUtlVector<uint> CtrlHash { get; }
  
  public ref CUtlVector<CUtlString> CtrlName { get; }
  
  public ref uint StaticNodeFlags { get; }
  
  public ref uint DynamicNodeFlags { get; }
  
  public ref float LocalForce { get; }
  
  public ref float LocalRotation { get; }
  
  public ref ushort NodeCount { get; }
  
  public ref ushort StaticNodes { get; }
  
  public ref ushort RotLockStaticNodes { get; }
  
  public ref ushort FirstPositionDrivenNode { get; }
  
  public ref ushort SimdTriCount1 { get; }
  
  public ref ushort SimdTriCount2 { get; }
  
  public ref ushort SimdQuadCount1 { get; }
  
  public ref ushort SimdQuadCount2 { get; }
  
  public ref ushort QuadCount1 { get; }
  
  public ref ushort QuadCount2 { get; }
  
  public ref ushort TreeDepth { get; }
  
  public ref ushort NodeBaseJiggleboneDependsCount { get; }
  
  public ref ushort RopeCount { get; }
  
  public ref CUtlVector<ushort> Ropes { get; }
  
  public ref CUtlVector NodeBases { get; }
  
  public ref CUtlVector SimdNodeBases { get; }
  
  public ref CUtlVector Quads { get; }
  
  public ref CUtlVector SimdQuads { get; }
  
  public ref CUtlVector SimdTris { get; }
  
  public ref CUtlVector SimdRods { get; }
  
  public ref CUtlVector SimdRodsAnim { get; }
  
  public ref CUtlVector<CTransform> InitPose { get; }
  
  public ref CUtlVector Rods { get; }
  
  public ref CUtlVector Twists { get; }
  
  public ref CUtlVector HingeLimits { get; }
  
  public ref CUtlVector<uint> AntiTunnelBytecode { get; }
  
  public ref CUtlVector DynKinLinks { get; }
  
  public ref CUtlVector AntiTunnelProbes { get; }
  
  public ref CUtlVector<ushort> AntiTunnelTargetNodes { get; }
  
  public ref CUtlVector AxialEdges { get; }
  
  public ref CUtlVector<float> NodeInvMasses { get; }
  
  public ref CUtlVector CtrlOffsets { get; }
  
  public ref CUtlVector CtrlOsOffsets { get; }
  
  public ref CUtlVector FollowNodes { get; }
  
  public ref CUtlVector CollisionPlanes { get; }
  
  public ref CUtlVector NodeIntegrator { get; }
  
  public ref CUtlVector SpringIntegrator { get; }
  
  public ref CUtlVector SimdSpringIntegrator { get; }
  
  public ref CUtlVector WorldCollisionParams { get; }
  
  public ref CUtlVector<float> LegacyStretchForce { get; }
  
  public ref CUtlVector<float> NodeCollisionRadii { get; }
  
  public ref CUtlVector<float> DynNodeFriction { get; }
  
  public ref CUtlVector<float> LocalRotation { get; }
  
  public ref CUtlVector<float> LocalForce { get; }
  
  public ref CUtlVector TaperedCapsuleStretches { get; }
  
  public ref CUtlVector TaperedCapsuleRigids { get; }
  
  public ref CUtlVector SphereRigids { get; }
  
  public ref CUtlVector<ushort> WorldCollisionNodes { get; }
  
  public ref CUtlVector<ushort> TreeParents { get; }
  
  public ref CUtlVector<ushort> TreeCollisionMasks { get; }
  
  public ref CUtlVector TreeChildren { get; }
  
  public ref CUtlVector<ushort> FreeNodes { get; }
  
  public ref CUtlVector FitMatrices { get; }
  
  public ref CUtlVector FitWeights { get; }
  
  public ref CUtlVector ReverseOffsets { get; }
  
  public ref CUtlVector AnimStrayRadii { get; }
  
  public ref CUtlVector SimdAnimStrayRadii { get; }
  
  public ref CUtlVector KelagerBends { get; }
  
  public ref CUtlVector CtrlSoftOffsets { get; }
  
  public ref CUtlVector JiggleBones { get; }
  
  public ref CUtlVector<ushort> SourceElems { get; }
  
  public ref CUtlVector<uint> GoalDampedSpringIntegrators { get; }
  
  public ref CUtlVector Tris { get; }
  
  public ref ushort TriCount1 { get; }
  
  public ref ushort TriCount2 { get; }
  
  public ref byte ReservedUint8 { get; }
  
  public ref byte ExtraPressureIterations { get; }
  
  public ref byte ExtraGoalIterations { get; }
  
  public ref byte ExtraIterations { get; }
  
  public ref CUtlVector SDFRigids { get; }
  
  public ref CUtlVector BoxRigids { get; }
  
  public ref CUtlVector<byte> DynNodeVertexSet { get; }
  
  public ref CUtlVector<uint> VertexSetNames { get; }
  
  public ref CUtlVector RigidColliderPriorities { get; }
  
  public ref CUtlVector MorphLayers { get; }
  
  public ref CUtlVector<byte> MorphSetData { get; }
  
  public ref CUtlVector VertexMaps { get; }
  
  public ref CUtlVector<byte> VertexMapValues { get; }
  
  public ref CUtlVector Effects { get; }
  
  public ref CUtlVector LockToParent { get; }
  
  public ref CUtlVector<ushort> LockToGoal { get; }
  
  public ref CUtlVector<short> SkelParents { get; }
  
  public ref CUtlVector DynNodeWindBases { get; }
  
  public ref float InternalPressure { get; }
  
  public ref float DefaultTimeDilation { get; }
  
  public ref float Windage { get; }
  
  public ref float WindDrag { get; }
  
  public ref float DefaultSurfaceStretch { get; }
  
  public ref float DefaultThreadStretch { get; }
  
  public ref float DefaultGravityScale { get; }
  
  public ref float DefaultVelAirDrag { get; }
  
  public ref float DefaultExpAirDrag { get; }
  
  public ref float DefaultVelQuadAirDrag { get; }
  
  public ref float DefaultExpQuadAirDrag { get; }
  
  public ref float RodVelocitySmoothRate { get; }
  
  public ref float QuadVelocitySmoothRate { get; }
  
  public ref float AddWorldCollisionRadius { get; }
  
  public ref float DefaultVolumetricSolveAmount { get; }
  
  public ref float MotionSmoothCDT { get; }
  
  public ref float LocalDrag1 { get; }
  
  public ref ushort RodVelocitySmoothIterations { get; }
  
  public ref ushort QuadVelocitySmoothIterations { get; }
  
}