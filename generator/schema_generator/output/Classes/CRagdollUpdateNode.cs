using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CRagdollUpdateNode : CUnaryUpdateNode, IRagdollUpdateNode {

  public CRagdollUpdateNode(nint handle) : base(handle) {
  }

  public ref int WeightListIndex {
    get => ref _Handle.AsRef<int>(Schema.GetOffset(0xB7502AF030288377));
  }
  public ref RagdollPoseControl PoseControlMethod {
    get => ref _Handle.AsRef<RagdollPoseControl>(Schema.GetOffset(0xB7502AF088DA12AC));
  }


}