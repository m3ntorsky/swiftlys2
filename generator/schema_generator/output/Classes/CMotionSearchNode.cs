using SwiftlyS2.Core.Schemas;
using SwiftlyS2.Shared.Schemas;
using SwiftlyS2.Core.Extensions;

namespace SwiftlyS2.Core.SchemaDefinitions;

internal partial class CMotionSearchNode : SchemaClass, IMotionSearchNode {

  public CMotionSearchNode(nint handle) : base(handle) {
  }

  public CMotionSearchNode(nint handle, ulong hash, bool isField, bool isNetworked) : base(handle, hash, isField, isNetworked) {
  }

  public ref CUtlVector< CMotionSearchNode* > Children {
    get => ref _Handle.AsRef<CUtlVector< CMotionSearchNode* >>(Schema.GetOffset(0x7CB28AA07415FA72));
  }
  public IVectorQuantizer Quantizer {
    get => new CVectorQuantizer(_Handle + Schema.GetOffset(0x7CB28AA0C7DE6374));
  }
  public ref CUtlVector< CUtlVector< SampleCode > > SampleCodes {
    get => ref _Handle.AsRef<CUtlVector< CUtlVector< SampleCode > >>(Schema.GetOffset(0x7CB28AA0D703E42F));
  }
  public ref CUtlVector< CUtlVector< int32 > > SampleIndices {
    get => ref _Handle.AsRef<CUtlVector< CUtlVector< int32 > >>(Schema.GetOffset(0x7CB28AA02EDA0064));
  }
  public ref CUtlVector< int32 > SelectableSamples {
    get => ref _Handle.AsRef<CUtlVector< int32 >>(Schema.GetOffset(0x7CB28AA0C1D40F34));
  }


}