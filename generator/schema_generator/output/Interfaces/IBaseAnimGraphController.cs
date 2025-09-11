using SwiftlyS2.Shared.Schemas;

namespace SwiftlyS2.Core.SchemaDefinitions;

public partial interface IBaseAnimGraphController : ISkeletonAnimationController {

  
  public IAnimGraphNetworkedVariables AnimGraphNetworkedVars { get; }
  
  public ref bool SequenceFinished { get; }
  
  public ref float SoundSyncTime { get; }
  
  public ref uint ActiveIKChainMask { get; }
  
  public IHSequence Sequence { get; }
  
  public IGameTime_t SeqStartTime { get; }
  
  public ref float SeqFixedCycle { get; }
  
  public ref AnimLoopMode_t AnimLoopMode { get; }
  
  public ref CNetworkedQuantizedFloat PlaybackRate { get; }
  
  public ref SequenceFinishNotifyState_t NotifyState { get; }
  
  public ref bool NetworkedAnimationInputsChanged { get; }
  
  public ref bool NetworkedSequenceChanged { get; }
  
  public ref bool LastUpdateSkipped { get; }
  
  public IGameTime_t PrevAnimUpdateTime { get; }
  
  public ref CStrongHandle<InfoForResourceTypeCNmGraphDefinition> GraphDefinitionAG2 { get; }
  
  public ref bool IsUsingAG2 { get; }
  
  public ref CUtlVector<byte> SerializedPoseRecipeAG2 { get; }
  
  public ref int SerializePoseRecipeSizeAG2 { get; }
  
  public ref byte GraphCreationFlagsAG2 { get; }
  
  public ref int ServerGraphDefReloadCountAG2 { get; }
}