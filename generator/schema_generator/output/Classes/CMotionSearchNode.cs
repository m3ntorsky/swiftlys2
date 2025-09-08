using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMotionSearchNode : SchemaClass, IMotionSearchNode {

  public CMotionSearchNode(nint handle) : base(handle) {
  }

  public ref CUtlVector<PointerTo<CMotionSearchNode>> Children {
    get => ref _Handle.AsRef<CUtlVector<PointerTo<CMotionSearchNode>>>(Schema.GetOffset(0x7CB28AA07415FA72));
  }
  public IVectorQuantizer Quantizer {
    get => new CVectorQuantizer(_Handle + Schema.GetOffset(0x7CB28AA0C7DE6374));
  }
  public ref CUtlVector<CUtlVector> SampleCodes {
    get => ref _Handle.AsRef<CUtlVector<CUtlVector>>(Schema.GetOffset(0x7CB28AA0D703E42F));
  }
  public ref CUtlVector<CUtlVector<int>> SampleIndices {
    get => ref _Handle.AsRef<CUtlVector<CUtlVector<int>>>(Schema.GetOffset(0x7CB28AA02EDA0064));
  }
  public ref CUtlVector<int> SelectableSamples {
    get => ref _Handle.AsRef<CUtlVector<int>>(Schema.GetOffset(0x7CB28AA0C1D40F34));
  }


}