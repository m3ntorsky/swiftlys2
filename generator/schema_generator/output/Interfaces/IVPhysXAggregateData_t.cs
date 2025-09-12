using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IVPhysXAggregateData_t : ISchemaClass {

  
  public ref ushort Flags { get; }
  
  public ref ushort RefCounter { get; }
  
  public ref CUtlVector<uint> BonesHash { get; }
  
  public ref CUtlVector<CUtlString> BoneNames { get; }
  
  public ref CUtlVector<ushort> IndexNames { get; }
  
  public ref CUtlVector<ushort> IndexHash { get; }
  
  public ref CUtlVector<matrix3x4_t> BindPose { get; }
  
// CUtlVector< VPhysXBodyPart_t >
  public ref CUtlVector Parts { get; }
  
// CUtlVector< PhysShapeMarkup_t >
  public ref CUtlVector ShapeMarkups { get; }
  
// CUtlVector< VPhysXConstraint2_t >
  public ref CUtlVector Constraints2 { get; }
  
// CUtlVector< VPhysXJoint_t >
  public ref CUtlVector Joints { get; }
  
  public IPhysFeModelDesc_t FeModel { get; }
  
  public ref CUtlVector<ushort> BoneParents { get; }
  
  public ref CUtlVector<uint> SurfacePropertyHashes { get; }
  
// CUtlVector< VPhysXCollisionAttributes_t >
  public ref CUtlVector CollisionAttributes { get; }
  
  public ref CUtlVector<CUtlString> DebugPartNames { get; }
  
  public ref CUtlString EmbeddedKeyvalues { get; }
}