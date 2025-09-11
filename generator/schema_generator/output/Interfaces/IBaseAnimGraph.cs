using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseAnimGraph : IBaseModelEntity {

  
  public ref bool InitiallyPopulateInterpHistory { get; }
  
  public IIChoreoServices ChoreoServices { get; }
  
  public ref bool AnimGraphUpdateEnabled { get; }
  
  public ref float MaxSlopeDistance { get; }
  
  public ref Vector LastSlopeCheckPos { get; }
  
  public ref bool AnimationUpdateScheduled { get; }
  
  public ref Vector Force { get; }
  
  public ref int ForceBone { get; }
  
  public IPhysicsRagdollPose_t RagdollPose { get; }
  
  public ref bool RagdollEnabled { get; }
  
  public ref bool RagdollClientSide { get; }
}