using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CNmChainSolverTask : CNmPoseTask, INmChainSolverTask {

  public CNmChainSolverTask(nint handle) : base(handle) {
  }

  public ref int EffectorBoneIdx {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5D675A12A9C233BE));
  }
  public ref CTransform TargetTransform {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0x5D675A12B1497974));
  }
  public ref int NumBonesInChain {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0x5D675A12CAD2EB3E));
  }
  public INmTarget EffectorTarget {
    get => new CNmTarget(_Handle + Schema.GetOffset(0x5D675A128D86AF5C));
  }
  public ref NmIKBlendMode_t BlendMode {
    get => ref _Handle.AsRef<NmIKBlendMode_t>(Schema.GetOffset(0x5D675A128D5006AB));
  }
  public ref float BlendWeight {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5D675A12E5D6B9CE));
  }
  public ref bool IsTargetInWorldSpace {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5D675A125F56E0C5));
  }
  public ref bool IsRunningFromDeserializedData {
    get => ref _Handle.AsRef<bool>(Schema.GetOffset(0x5D675A124791111D));
  }
  public ref CGlobalSymbol DebugEffectorBoneID {
    get => ref _Handle.AsRef<CGlobalSymbol>(Schema.GetOffset(0x5D675A12A9F0F1F3));
  }
  public ref CTransform ChainStartTransformMS {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0x5D675A12E1B47AFE));
  }
  public ref CTransform DebugRequestedTargetTransformMS {
    get => ref _Handle.AsRef<CTransform>(Schema.GetOffset(0x5D675A12416A1F2F));
  }
  public ref float DebugTotalChainLength {
    get => ref _Handle.AsRef<float>(Schema.GetOffset(0x5D675A125ED39D2F));
  }


}