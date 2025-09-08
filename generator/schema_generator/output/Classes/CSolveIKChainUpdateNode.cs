using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CSolveIKChainUpdateNode : CUnaryUpdateNode, ISolveIKChainUpdateNode {

  public CSolveIKChainUpdateNode(nint handle) : base(handle) {
  }

  public ref CUtlVector TargetHandles {
    get => ref _Handle.AsRef<CUtlVector>(Schema.GetOffset(0xE78F1D1F98E248F7));
  }
  public ISolveIKChainPoseOpFixedSettings_t OpFixedData {
    get => new SolveIKChainPoseOpFixedSettings_t(_Handle + Schema.GetOffset(0xE78F1D1F6960AF8C));
  }


}